using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySound
{
    public partial class FormMain : Form
    {
        
        private bool isInitial = true;
       

        public FormMain()
        {
            InitializeComponent();
            
            if (Properties.Settings.Default.wavePath != "")
            {
                LoadWaveFile(Properties.Settings.Default.wavePath);
            };
            comboBoxKeys.Items.AddRange( Enum.GetValues(typeof(Keys)).Cast<Keys>().Select(p => p.ToString()).ToArray() );
            if (Properties.Settings.Default.shortcutKey != "")
            {
                comboBoxKeys.SelectedItem = Properties.Settings.Default.shortcutKey;
            };

            this.Text = Program.BuildFormTitle();

            isInitial = false;

            comboBox1.Text = Properties.Settings.Default.waveName;

        }



        public  void LoadWaveFile(string file)
        {
            if (!File.Exists(file))
            {
                textBoxFilePath.ForeColor = Color.Red;
                return;
            }
            textBoxFilePath.ForeColor = Color.Black;
            textBoxFilePath.Text = file;

            //Program._soundPlayer.SoundLocation = Properties.Settings.Default.wavePath;
        }

        


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog1.FileName;
                Properties.Settings.Default.wavePath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
                LoadWaveFile(openFileDialog1.FileName);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Program._soundPlayer.Play();
        }

        private void buttonTestEnd_Click(object sender, EventArgs e)
        {
            Program._soundPlayer.Stop();
        }

        private void comboBoxKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitial) return;
            Properties.Settings.Default.shortcutKey = comboBoxKeys.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            Enum.TryParse(Properties.Settings.Default.shortcutKey, out Program.hotKey);
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isInitial) return;
            Properties.Settings.Default.waveName = comboBox1.Text;
            Properties.Settings.Default.Save();
            Program._soundPlayer.Stream = Properties.Resources.ResourceManager.GetStream(comboBox1.Text);
        }
    }
}
