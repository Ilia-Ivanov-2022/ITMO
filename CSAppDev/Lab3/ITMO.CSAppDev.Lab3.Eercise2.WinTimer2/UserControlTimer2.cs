using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSAppDev.Lab3.Exercise2.WinTimer2
{
    public partial class UserControlTimer2 : Control
    {
        public UserControlTimer2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            // determine our rectangule
            Graphics g = pe.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);
            // determine timer
            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(), this.Font,
                new SolidBrush(this.ForeColor), 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
