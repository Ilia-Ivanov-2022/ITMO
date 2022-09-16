using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab4.Ex4.DataAdapterProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Instance of connection.
        private SqlConnection NorthwindConnection = new SqlConnection(
            "Data Source = (local); Initial Catalog = Northwind;" +
            " Integrated Security = true");
        // Instance of DataAdapter.
        private SqlDataAdapter SqlDataAdapter1;
        // DataSet with Customers table of Northwind DataBase.
        private DataSet NorthwindDataSet = new DataSet("Northwind");
        private DataTable CustomersTable = new DataTable("Customers");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers",
                NorthwindConnection);
            NorthwindDataSet.Tables.Add(CustomersTable);
            SqlDataAdapter1.Fill(NorthwindDataSet.Tables["Customers"]);
            dataGridView1.DataSource = NorthwindDataSet.Tables["Customers"];
            SqlCommandBuilder command = new SqlCommandBuilder(SqlDataAdapter1);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.EndInit();
            SqlDataAdapter1.Update(NorthwindDataSet.Tables["Customers"]);
        }
    }
}
