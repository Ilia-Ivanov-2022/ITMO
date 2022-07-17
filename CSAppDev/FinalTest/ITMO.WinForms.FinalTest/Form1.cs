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


namespace ITMO.WinForms.FinalTest
{
    public partial class Form1 : Form
    {
        // connect class clsDataBaseMSSQL to Form1
        clsDataBaseMSSQL dataBase = new clsDataBaseMSSQL();

        // field for work with database
        int selectedRow;

        public Form1()
        {
            InitializeComponent();
        }
        
        // columns for dataGridView1
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "Product ID");
            dataGridView1.Columns.Add("Name", "Product Name");
            dataGridView1.Columns.Add("Number", "Quantity");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Discount", "Discount");
        }

        // reading data from DataBase by a single row
        private void ReadSingleRow(DataGridView dGW, IDataRecord myRecord)
        {
            dGW.Rows.Add(myRecord.GetInt32(0),
                        myRecord.GetString(1),
                        myRecord.GetInt64(2), 
                        myRecord.GetDecimal(3), 
                        myRecord.GetDecimal(4));
        }

        // fill up dataGridView1 with records from ReadSingleRow
        private void FillupDataGrid(DataGridView dGW)
        {
            dGW.Rows.Clear();                               // clear the dataGridView
            string queryString = $"SELECT * FROM dbo.t1";   // use below for connection
            SqlCommand cmd = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dGW, reader);
            }
            reader.Close();
        }
        // load FillupDataGrid into our form
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            FillupDataGrid(dataGridView1);
        }

        // search string in dataBase
        private void SearchDB(DataGridView dGW)
        {
            dataGridView1.Rows.Clear();
            string searchString = $"SELECT * FROM dbo.t1 WHERE (ID + Name + Number + Price + Discount)" +
                $" LIKE '%" + textBoxSearch.Text + "%'";
            SqlCommand cmd = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dGW, reader);
            }
            reader.Close();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDB(dataGridView1);
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataBase.openConnection();
            int ProductId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            string deleteQuery = $"DELETE FROM t1 WHERE ID = '{ProductId}'";

            SqlCommand cmd = new SqlCommand(deleteQuery, dataBase.getConnection());
            cmd.ExecuteNonQuery();
            dataBase.closeConnection();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            FillupDataGrid(dataGridView1);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_ProductId.Text = row.Cells[0].Value.ToString();
                textBox_ProductName.Text = row.Cells[1].Value.ToString();
                textBox_Quantity.Text = row.Cells[2].Value.ToString();
                textBox_Price.Text = row.Cells[3].Value.ToString();
                textBox_Discount.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillupDataGrid(dataGridView1);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            formAddNew.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
