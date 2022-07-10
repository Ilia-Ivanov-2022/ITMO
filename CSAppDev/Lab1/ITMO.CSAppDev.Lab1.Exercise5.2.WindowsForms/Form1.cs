using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITMO.CSAppDeb.Lab1.Exercise5._2.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // draw a rhombus
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] {
                new Point(this.Width / 2, 0),
                new Point(this.Width, this.Height / 2),
                new Point(this.Width / 2, this.Height),
                new Point(0, this.Height / 2)
                });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e) // this button closes the form
        {
            this.Close();
        }
    }
}
