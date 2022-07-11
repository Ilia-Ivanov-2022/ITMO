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
                //textBox.Keypress check -only digits may be entered. Other parts of keyboard are blocked.
                //txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
                // Another way using validating
                txt.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox2_Validating);
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
        // textBox1.Keypress check - only letters may be entered
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The input box 'Name' may not contain digits");
                errorProvider1.SetError(textBox1, "Must be letters");
            }
        }
        // Another way of
        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if(textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel=true;
                    MessageBox.Show("The input box PIN may not contain letters");
                }
            }
            errorProvider1.SetError(textBox2, "Must be digits");
        }
        //// textBox2.Keypress check - only digits may be entered. Other parts of keyboard are blocked.
        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("The input box 'PIN' may not contain letters");
        //    }
        //}
    }
}
