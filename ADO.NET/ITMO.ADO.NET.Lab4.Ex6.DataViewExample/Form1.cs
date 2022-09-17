using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab4.Ex6.DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Instances of DataView for Customers and Orders.
        DataView customersDataView;
        DataView ordersDataView;
        // Form1 Load event handler.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data in the tables.
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);
            // Setup DataSet to use Customers and Orders.
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);
            // Setup sorting order.
            customersDataView.Sort = "CustomerID";
            // Setup CustomerGrid to display CustomerDataView.
            CustomersGrid.DataSource = customersDataView;
        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = SortTextBox.Text;
            customersDataView.RowFilter = FilterTextBox.Text;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            // New row.
            DataRowView newCustomRow = customersDataView.AddNew();
            // Set values for columns CustomerID and CompanyName.
            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toys";
            // Explicit end of edit.
            newCustomRow.EndEdit();
        }

        private void GetOrdersButton_Click(object sender, EventArgs e)
        {
            // Get CustomerID for a row selected in CustomersGrid.
            string selectedCustomerID =
                (string)CustomersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            // Create an instance of DataRowView and assign it a selected row.
            DataRowView selectedRow =
                customersDataView[customersDataView.Find(selectedCustomerID)];
            // Call CreateChildView() to move around the reacords and to create a new
            // DataView based on linked records.
            ordersDataView =
                selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
            // Set OrderGrid to display linked DataView.
            OrdersGrid.DataSource = ordersDataView;
        }
    }
}
