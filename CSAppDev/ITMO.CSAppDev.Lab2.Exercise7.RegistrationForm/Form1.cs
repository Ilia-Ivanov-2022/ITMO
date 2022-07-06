using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSAppDev.Lab2.Exercise7.RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                // Advanced settings. Add new element when checkBox1 == true
                // New label 'PIN2'
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(14, 85);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "label11";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox1.Controls.Add(lbl);
                // New textBox empty
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(70, 80);
                txt.Size = new System.Drawing.Size(163, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else // remove an element by index when checkBox1 == false
            {
                int lcv;
                lcv = groupBox1.Controls.Count; // count total number of elements
                while (lcv > 4)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }
    }
}
