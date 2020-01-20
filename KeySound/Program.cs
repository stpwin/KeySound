using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace KeySound
{
    static class Program
    {
        private static readonly PrivateFontCollection _pfc = new PrivateFontCollection();
        public static Font myFont;
        public static Font contextMenuFont;
        public static Font toastFont;
        public static string toastMessage = "กำลังเล่นเสียง...";

        public static Keys hotKey;

        public static SoundPlayer _soundPlayer = new SoundPlayer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Initialize();
            var utils = new Utils();
            utils.Loop();

            //SingleInstance.SingleApplication.Run(new FormMain());
            //Application.Run(new FormMain());
        }

        private static void Initialize()
        {
            
            //_soundPlayer.SoundLocation = Properties.Settings.Default.wavePath;
            Enum.TryParse(Properties.Settings.Default.shortcutKey, out hotKey);
            _soundPlayer.Stream = Properties.Resources.ResourceManager.GetStream(Properties.Settings.Default.waveName);
            //Properties.Resources.ResourceManager.get
            LoadFont();
        }

        public static string BuildFormTitle()
        {
            //String AppName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            return $"{Application.ProductName} {Application.ProductVersion}";
        }

        private static void LoadFont()
        {
            //const string fontResourceName = "KeySound.Resources.CSChatThai.ttf";
            
            //var fontStream = typeof(Program).Assembly.GetManifestResourceStream(fontResourceName);
            //if (fontStream == null)
            //    throw new Exception($"Unable to find font '{fontResourceName}' in embedded resources.");

            //byte[] fontBytes = new byte[fontStream.Length];
            //fontStream.Read(fontBytes, 0, (int)fontStream.Length);
            //fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = Properties.Resources.CSChatThai)
                {
                    _pfc.AddMemoryFont((IntPtr)pFontData, Properties.Resources.CSChatThai.Length);
                }
            }
            
            myFont = new Font(_pfc.Families[0], 16, FontStyle.Regular);
            toastFont = new Font(_pfc.Families[0], 20, FontStyle.Bold);
            contextMenuFont = new Font(_pfc.Families[0], 12, FontStyle.Regular);
        }


        public static void ShowToastMessage(string msg)
        {
            var toast = new MessageToast(msg) { labelMessage = { Font = toastFont } };
            toast.Show();
        }
    }



    public class Utils : IOnHotkeyPressed
    {
        
        public Poller poller;

        public bool running = true;

        public Form formMain = new FormMain();
        //private Timer timer;
        public NotifyIcon notifyIcon = new NotifyIcon();
        public ContextMenuStrip contextMenu = new ContextMenuStrip();
        public ToolStripMenuItem ShowToolStripMenuItem = new ToolStripMenuItem();
        public ToolStripMenuItem ExitToolStripMenuItem = new ToolStripMenuItem();

        public Utils()
        {
            poller = new Poller(this);
            //timer = new Timer
            //{
            //    Interval = 10,
            //    //Enabled = true
            //};
            //timer.Tick += (sender, args) => poller.Poll(Program.hotKey);

            contextMenu.SuspendLayout();

            ShowToolStripMenuItem.Text = "ตั้งค่า";
            ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            ShowToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            ShowToolStripMenuItem.Click += ShowToolStripMenuItem_Click;
            ShowToolStripMenuItem.Font = Program.contextMenuFont;

            ExitToolStripMenuItem.Text = "ออก";
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            ExitToolStripMenuItem.Font = Program.contextMenuFont;

            contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ShowToolStripMenuItem, ExitToolStripMenuItem });
            contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            contextMenu.ShowImageMargin = false;
            contextMenu.ShowItemToolTips = false;
            contextMenu.Size = new System.Drawing.Size(74, 48);
            contextMenu.ResumeLayout(false);

            notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            notifyIcon.ContextMenuStrip = contextMenu;
            Update();
            //var icon = typeof(Program).Assembly.GetManifestResourceStream("KeySound.Resources.icon.ico");
            //if (icon is null)
            //{
            //    Console.WriteLine(@"icon is null");
            //}
            //else
            //{

                notifyIcon.Icon = Properties.Resources.icon;
            //}

            notifyIcon.Visible = true;

        }

        public void Update()
        {
            notifyIcon.Text = $@"{Program.BuildFormTitle()}
{(Program.hotKey == Keys.None ? "ยังไม่ได้ตั้งค่าคีย์ลัด" : "กด " + Program.hotKey + " เพื่อเล่นเสียง")}";
        }


        public void Loop()
        {
            while (running)
            {
                poller.Poll(Program.hotKey);
                Application.DoEvents();
                Thread.Sleep(1);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            running = false;
            Application.Exit();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SingleInstance.SingleApplication.Run(new FormMain());
            if (formMain.IsDisposed) formMain = new FormMain();
            if (formMain.Visible) return;
            formMain.ShowDialog();
            Update();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //SingleInstance.SingleApplication.Run(new FormMain());
            if (formMain.IsDisposed) formMain = new FormMain();
            if (formMain.Visible) return;
            formMain.ShowDialog();
            Update();
        }

        #region Interface methods

        public void OnPressed()
        {
            Program._soundPlayer.Play();
            Program.ShowToastMessage(Program.toastMessage);
        }

        #endregion


    }


}
