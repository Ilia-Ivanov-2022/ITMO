using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab1.Ex2.DBConnection
{
    public partial class FormMain : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwing;Data Source=beast-machine";

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
            catch (OleDbException XcpSQL)
            {
                foreach(OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                                    "SQL Error Code " + se.NativeError,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch(Exception Xcp)
            {
                MessageBox.Show(Xcp.Message,
                                "Unexpected Exception",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
