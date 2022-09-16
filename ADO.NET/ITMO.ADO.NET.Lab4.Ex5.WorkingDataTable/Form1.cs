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

namespace ITMO.ADO.NET.Lab4.Ex5.WorkingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView connection to Customer table.
            CustomersDataGridView.DataSource = northwindDataSet1.Customers;
            CustomersDataGridView.MultiSelect = false;
            CustomersDataGridView.SelectionMode =
                DataGridViewSelectionMode.CellSelect;
            CustomersDataGridView.EditMode =
                DataGridViewEditMode.EditProgrammatically;
        }

        private void FillTableButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.CustomersRow NewRow =
                (NorthwindDataSet.CustomersRow)northwindDataSet1.Customers.NewRow();
            // Set value for each row.
            NewRow.CustomerID = "WINGT";
            NewRow.CompanyName = "Wingtip Toys";
            NewRow.ContactName = "Steve Lasker";
            NewRow.ContactTitle = "CEO";
            NewRow.Address = "1234 Main Street";
            NewRow.City = "Buffalo";
            NewRow.Region = "NY";
            NewRow.PostalCode = "98052";
            NewRow.Country = "USA";
            NewRow.Phone = "206-555-0111";
            NewRow.Fax = "206-555-0112";
            // Add the row to Row collection of Customers table.
            try
            {
                northwindDataSet1.Customers.Rows.Add(NewRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }
        }

        // Return row selected in DataGridView CustomersRow.
        private NorthwindDataSet.CustomersRow GetSelectedRow()
        {
            String SelectedCustomerID =
                CustomersDataGridView.CurrentRow.Cells["CustomerID"].Value.ToString();
            NorthwindDataSet.CustomersRow SelectedRow =
                northwindDataSet1.Customers.FindByCustomerID(SelectedCustomerID);
            return SelectedRow;
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }
        // Update textBoxes.
        private void UpdateRowVersionDisplay()
        {
            try
            {
                CurrentDRVTextBox.Text =
                    GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name,
                    DataRowVersion.Current].ToString();
            }
            catch(Exception ex)
            {
                CurrentDRVTextBox.Text = ex.Message;
            }
            try
            {
                OriginalDRVTextBox.Text =
                    GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name,
                    DataRowVersion.Original].ToString();
            }
            catch(Exception ex)
            {
                OriginalDRVTextBox.Text = ex.Message;
            }
            // RowState of a selected row.
            RowStateTextBox.Text = GetSelectedRow().RowState.ToString();
        }

        private void UpdateValueButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name] =
                CellValueTextBox.Text;
            UpdateRowVersionDisplay();
        }

        private void CustomersDataGridView_Click(object sender, EventArgs e)
        {
            // Fill CellValueTextBox with value of selected cell.
            CellValueTextBox.Text =
                CustomersDataGridView.CurrentCell.Value.ToString();
            // Update other textBoxes.
            UpdateRowVersionDisplay();
        }

        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void RejectChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();
        }
    }
}
