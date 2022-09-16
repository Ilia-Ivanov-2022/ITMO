using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO.NET.Lab4.Ex._1.DataSetDesigner
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            // Instance of dataset type Northwind.
            NorthwindDataSet northWindDataSet1 = new NorthwindDataSet();
            // Instance of CustomerTableAdaoter.
            NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1 =
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            // Fill Customers in DataTable method.
            customersTableAdapter1.Fill(northWindDataSet1.Customers);
            // Pass value of CompanyName row into ListBox.
            foreach(NorthwindDataSet.CustomersRow NWCustomer
                in northWindDataSet1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}
