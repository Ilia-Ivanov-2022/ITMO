using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab1.Ex2.DBConnection
{
    public partial class FormMain : Form
    {
        OleDbConnection connection = new OleDbConnection();
       
        // Form ctor.
        public FormMain()
        {
            InitializeComponent();
            // connection state.
            this.connection.StateChange += new StateChangeEventHandler(connection_StateChange);
        }
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = 
                ConfigurationManager.ConnectionStrings[name];
            if(settings != null)
            {
                returnValue = settings.ConnectionString;
            }
            return returnValue;
        }
        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        // Event handlers.
        private void clickConnect(object sender, System.EventArgs e)
        {
            try
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Successfully connected to data base.");
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
                MessageBox.Show("Connection to data base already has been closed.");
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            connectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void clickConnList(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if(settings != null)
            {
                foreach(ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("Name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " +cs.ConnectionString);
                }
            }
        }

        private void clickBtnProductQuatity(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                OleDbCommand oleDbСmd = new OleDbCommand();
                oleDbСmd.Connection = connection;
                oleDbСmd.CommandText = "SELECT COUNT (*) FROM Products";
                int resultQuery = (int)oleDbСmd.ExecuteScalar();
                lblProductQuantity.Text = resultQuery.ToString();
            }
            else
            {
                MessageBox.Show("Open connection.");
            }
        }

        private void clickBtnProductList(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Open)
            {
                OleDbCommand oleDbCmd = connection.CreateCommand();
                oleDbCmd.CommandText = "SELECT ProductName FROM Products";
                OleDbDataReader reader = oleDbCmd.ExecuteReader();
                while (reader.Read())
                {
                    lstProductList.Items.Add(reader["ProductName"].ToString());
                }
            }
            else
                MessageBox.Show("Open connection.");
        }

        private void clickBtnTransction(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(testConnect);
            connection.Open();
            OleDbTransaction oleTran = connection.BeginTransaction();
            OleDbCommand oleDbCommand = connection.CreateCommand();
            oleDbCommand.Transaction = oleTran;
            try
            {
                oleDbCommand.CommandText = "INSERT INTO Products (ProductName)" +
                    "VALUES('Wrong Size')";
                oleDbCommand.ExecuteNonQuery();
                oleDbCommand.CommandText = "INSERT INTO Products (ProductName)" +
                    "VALUES('Wrong Color')";
                oleDbCommand.ExecuteNonQuery();
                oleTran.Commit();
                MessageBox.Show("Both records have been written into database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    oleTran.Rollback();
                }
                catch(Exception exRollback)
                {
                    MessageBox.Show(exRollback.Message);
                }
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
