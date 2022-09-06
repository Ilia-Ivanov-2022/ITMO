using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab1.Ex2.DBConnection
{
    public partial class FormMain : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=beast-machine";

        public FormMain()
        {
            InitializeComponent();
        }

        
        private void clickConnect(object sender, System.EventArgs e)
        {
            try
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Successful connection to data base.");
                }
                else
                    MessageBox.Show("Connection to data base already exists.");
            }
            catch
            {
                MessageBox.Show("Connection error.");
            }
        }

        private void clickDisconnect(object sender, System.EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Connection to data base is closed.");
            }
            else
                MessageBox.Show("Connection to data base has been already closed.");
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
