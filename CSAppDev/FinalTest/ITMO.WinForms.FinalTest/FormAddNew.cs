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
using System.Globalization;

namespace ITMO.WinForms.FinalTest
{
    public partial class FormAddNew : Form
    {
        // connect class clsDataBaseMSSQL to Form1
        clsDataBaseMSSQL dataBase = new clsDataBaseMSSQL();
        public FormAddNew()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSaveAddNew_Click(object sender, EventArgs e)
        {
            // assign variables to textBoxes records
            string ProductName = textBox_ProductNameAddNew.Text;
            Int64 Quantity = Int64.Parse(textBox_QuantityAddNew.Text);
            decimal Price = decimal.Parse(textBox_PriceAddNew.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"));
            decimal Discount = decimal.Parse(textBox_DiscountAddNew.Text, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"));

            string addQuery = $"INSERT INTO dbo.t1 (Name, Number, Price, Discount) " +
                $"VALUES ('{ProductName}', {Quantity}, @Price, @Discount)";

            dataBase.openConnection();
            SqlCommand cmd = new SqlCommand(addQuery, dataBase.getConnection());
            cmd.Parameters.AddWithValue("Price", Price);
            cmd.Parameters.AddWithValue("Discount", Discount);
            cmd.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        private void FormAddNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test_blockDataSet.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.test_blockDataSet.t1);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
