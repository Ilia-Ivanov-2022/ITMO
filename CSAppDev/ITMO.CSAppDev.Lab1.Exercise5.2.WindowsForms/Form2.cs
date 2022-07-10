using System;
using System.Windows.Forms;

namespace ITMO.CSAppDeb.Lab1.Exercise5._2.WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
