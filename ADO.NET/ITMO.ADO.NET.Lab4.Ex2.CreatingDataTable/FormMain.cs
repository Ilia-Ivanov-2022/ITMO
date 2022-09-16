using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab4.Ex2.CreatingDataTable
{
    public partial class FormMain : Form
    {
        // Table instance.
        private DataTable CustomersTable = new DataTable("Customers");
        public FormMain()
        {
            InitializeComponent();

            try
            {
                // Option of creating table via Form Initialization.
                // Set DataGridView source as CustomerTable.
                TableGrid.DataSource = CustomersTable;
                // Set table schema.
                CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
                CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
                CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
                CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
                CustomersTable.Columns.Add("City", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));
                // Set CustomerID row as a Primary Key.
                DataColumn[] KeyColumns = new DataColumn[1];
                KeyColumns[0] = CustomersTable.Columns["CustomerID"];
                CustomersTable.PrimaryKey = KeyColumns;
                // Set Columns CustomerID and CustomerName to NOT NULL.
                CustomersTable.Columns["CustomerID"].AllowDBNull = false;
                CustomersTable.Columns["CustomerName"].AllowDBNull = false;
            }
            catch(NullReferenceException exNRE)
            {
                MessageBox.Show(exNRE.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    private void AddRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow CustRow = CustomersTable.NewRow();
                Object[] CustRecord = {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                "Sales Representative", "Obere Str. 57", "Berlin",
                 "Germany", "030-0074321"};
                CustRow.ItemArray = CustRecord;
                // Add record into table.
                CustomersTable.Rows.Add(CustRow);
            }
            catch(ConstraintException exConstr)
            {
                MessageBox.Show(exConstr.Message);
            }
            catch(NullReferenceException exNull)
            {
                MessageBox.Show(exNull.Message);
            }
            catch(ArgumentException exArg)
            {
                MessageBox.Show(exArg.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.GetType().Name);
            }
        }
    }
}
