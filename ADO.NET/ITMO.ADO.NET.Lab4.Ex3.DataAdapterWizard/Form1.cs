using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab4.Ex3.DataAdapterWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindDataSet1.Customers;
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(northwindDataSet1);
        }

        private void OnRowUpdating(object sender, SqlRowUpdatingEventArgs e)
        {
            NorthwindDataSet.CustomersRow CustRow = 
                (NorthwindDataSet.CustomersRow)e.Row;
            DialogResult responce = MessageBox.Show("Continue updating" +
                CustRow.CustomerID.ToString() + "?", "Continue update?",
                MessageBoxButtons.YesNo);
            if(responce == DialogResult.No)
            {
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }
        private void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            NorthwindDataSet.CustomersRow CustRow = 
                (NorthwindDataSet.CustomersRow)e.Row;
            MessageBox.Show(CustRow.CustomerID.ToString() + " has been update.");
            // Reset of the table after update to display updated values.
            northwindDataSet1.Customers.Clear();
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }
        public void FillErrorEventHandler(object sender,
            FillErrorEventArgs e)
        {
            DialogResult response = MessageBox.Show("The following error occured" +
                "while Filling the DataSet: " + e.Errors.Message.ToString() +
                " Continue attempting to fill?", "FillError Encountered",
                MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                e.Continue = true;
            }
            else
                e.Continue = false;
        }
    }
}
