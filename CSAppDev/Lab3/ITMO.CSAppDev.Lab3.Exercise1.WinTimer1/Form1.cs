using System;
using System.Windows.Forms;

namespace ITMO.CSAppDev.Lab3.Exercise1.WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControlTimer1.TimeEnabled == true) 
            { 
                userControlTimer1.TimeEnabled = false;
                button1.Text = "Start";
            }
            else 
            { 
                userControlTimer1.TimeEnabled = true;
                button1.Text = "Stop";
            }
        }
    }
}
