using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySound
{
    public partial class FormMain : Form, IOnHotkeyPressed
    {
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        private Font myFont;
        private Font contextMenuFont;
        private Font toastFont;
        private SoundPlayer _soundPlayer = new SoundPlayer();
        private bool isInitial = true;
        private Poller poller;
        private Keys hotKey;
        private string toastMessage = "กำลังเล่นเสียง";

        public FormMain()
        {
            InitializeComponent();
            loadFont();
            poller = new Poller(this);
            if (Properties.Settings.Default.wavePath != "")
            {
                this.loadWaveFile(Properties.Settings.Default.wavePath);
            };
            comboBoxKeys.Items.AddRange(Enum.GetValues(typeof(Keys)).Cast<Keys>().Select(p => p.ToString()).ToArray());
            if (Properties.Settings.Default.shortcutKey != "")
            {
                comboBoxKeys.SelectedItem = Properties.Settings.Default.shortcutKey;
            };
            contextMenuStrip1.Font = contextMenuFont;
            this.Text = BuildFormTitle();
            notifyIcon1.Text = this.Text;
            
            isInitial = false;
        }

        #region Interface methods

        public void OnPressed()
        {
            _soundPlayer.Play();
            showToastMessage(toastMessage);
        }

        #endregion

        private void showToastMessage(string msg)
        {
            var toast = new MessageToast(msg);
            toast.labelMessage.Font = toastFont;
            toast.Show();
        }

        private void loadWaveFile(string file)
        {
            if (!File.Exists(file))
            {
                textBoxFilePath.ForeColor = Color.Red;
                return;
            }
            textBoxFilePath.ForeColor = Color.Black;
            textBoxFilePath.Text = file;
            _soundPlayer.SoundLocation = Properties.Settings.Default.wavePath;
        }

        private void loadFont()
        {
            var fontResourceName = "KeySound.Resources.CSChatThai.ttf";
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream(fontResourceName);
            if (fontStream == null)
                throw new Exception(string.Format("Unable to find font '{0}' in embedded resources.", fontResourceName));
            
            byte[] fontBytes = new byte[fontStream.Length];
            fontStream.Read(fontBytes, 0, (int) fontStream.Length);
            fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontBytes)
                {
                     _pfc.AddMemoryFont((IntPtr)pFontData, fontBytes.Length);
                }
            }

            myFont = new Font(_pfc.Families[0], 16, FontStyle.Regular);
            toastFont = new Font(_pfc.Families[0], 20, FontStyle.Bold);
            contextMenuFont = new Font(_pfc.Families[0], 12, FontStyle.Regular);
            this.Font = myFont;
        }

        private String BuildFormTitle()
        {
            //String AppName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            String FormTitle = String.Format("{0} {1}",
                //AppName,
                Application.ProductName,
                Application.ProductVersion);
            return FormTitle;
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog1.FileName;
                Properties.Settings.Default.wavePath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
                this.loadWaveFile( openFileDialog1.FileName);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void buttonTestEnd_Click(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
        }

        private void comboBoxKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitial)
            {
                Properties.Settings.Default.shortcutKey = comboBoxKeys.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }

            Enum.TryParse(Properties.Settings.Default.shortcutKey, out Keys _hotKey);
            this.hotKey = _hotKey;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            poller.Poll(this.hotKey);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
            timer2.Stop();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
