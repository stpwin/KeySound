using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySound
{
    public partial class MessageToast : Form
    {
        public MessageToast(string message)
        {
            InitializeComponent();
            this.labelMessage.Text = message;
            
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 50);
        }

        public MessageToast(string message, int timerIntervalMs = 1000) : this(message)
        {
            this.timerShow.Interval = timerIntervalMs;
        }

        private void timerCloseForm_Tick(object sender, EventArgs e)
        {
            double newOpacity = this.Opacity - 2.0 / 100;
            if (newOpacity <= 0)
            {
                this.Close();
            }
            else
            {
                this.Opacity = newOpacity;
            }
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            this.timerShow.Enabled = false;
            this.timerCloseForm.Enabled = true;
        }
    }
}
