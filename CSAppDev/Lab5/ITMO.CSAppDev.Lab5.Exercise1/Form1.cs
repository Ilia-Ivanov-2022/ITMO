using System;
using System.Data;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace ITMO.CSAppDev.Lab5.Exercise1
{
    public partial class Form1 : Form
    {   // copy of Excel Application with all its atributes
        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;
                
        public Form1()
        {
            InitializeComponent();
        }
        // copy of data table
        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;

                try
                {
                    // load existing worlbook. The only parameter is a file path.
                    workbook = app.Workbooks.Open(ofd.FileName);
                    // access to a worksheet number 1
                    NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                    // cells containing values
                    ShtRange = NwSheet.UsedRange;

                    // load the first row from the table
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        dt.Columns.Add(new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                    }
                    dt.AcceptChanges();

                    // set a first row values as a column name
                    string[] columnNames = new String[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columnNames[0] = dt.Columns[i].ColumnName;
                    }

                    // load remaining rows and add to the table
                    for (int Rnum = 2; Rnum <= dt.Rows.Count; Rnum++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                            {
                                dr[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as
                                    ExcelObj.Range).Value2.ToString();
                            }
                        }
                        dt.Rows.Add(dr);    // add loaded rows to the table
                        dt.AcceptChanges();
                    }
                    // connect control to loaded table
                    dataGridView1.DataSource = dt;
                    app.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You have not select a file to open", "Loading data...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

