using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySound
{
    public partial class Separator : UserControl
    {
        public Separator()
        {
            InitializeComponent();
        }

        private void Separator_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.DimGray),0, 0,Width,0 );
        }
    }
}
