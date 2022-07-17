using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO.WinForms.FinalTest
{
    public partial class FormLogin : Form
    {
        // connect class clsDataBaseMSSQL to Form1
        clsDataBaseMSSQL dataBase = new clsDataBaseMSSQL();
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtbxPassword.PasswordChar = '*';   // hide entered password behind '*'
            txtbxPassword.MaxLength = 50;
            txtbxLogin.MaxLength = 50;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string loginUser = txtbxLogin.Text;         // variables for entered text
            string passwordUser = txtbxPassword.Text;   // in user and password textBoxes

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"SELECT userId, loginUser, passwordUser" +
                $" FROM Register WHERE loginUser = '{loginUser}' AND passwordUser = '{passwordUser}'";

            SqlCommand cmd = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("You have signed-in successfuly!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Such accout doesn't exists!","No such account!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
