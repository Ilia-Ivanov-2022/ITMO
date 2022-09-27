using System;
using System.Linq;
using System.Windows.Forms;

namespace ITMO.ADO.NET.EF.FinalTest.Crewing
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin2_Click(object sender, EventArgs e)
        {
            using (var ctx = new CrewingContext())
            {
                var userName = textBoxUserName.Text;
                var password = textBoxPassword.Text;
                if(ctx.Logins.First().UserName == userName && ctx.Logins.First().Password == password)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect User Name or Password.");
                };
            }
        }

        private void buttonCloseLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
