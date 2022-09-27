using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ITMO.ADO.NET.EF.Lab9.Ex1_2.CodeFirst.Model;

namespace ITMO.ADO.NET.EF.Lab9.Ex1and2.CustomerManager
{
    public partial class CustomerViewer : Form
    {
        public CustomerViewer()
        {
            InitializeComponent();
        }
        // Reference to context class.
        SampleContext context;
        // Reference to byte array for photo.
        byte[] Ph;

        private SampleContext GetContext()
        {
            return context;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonAdd_Click(sender, e, context);
        }

        private void buttonAdd_Click(object sender, EventArgs e, SampleContext context)
        {
            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            try
            {
                Customer customer = new Customer
                {
                    Name = this.textBoxname.Text,
                    Email = this.textBoxmail.Text,
                    Age = Int32.Parse(this.textBoxage.Text),
                    Photo = Ph
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                textBoxname.Text = String.Empty;
                textBoxmail.Text = String.Empty;
                textBoxage.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(diag.OpenFile());

                ImageConverter converter = new ImageConverter();
                Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }
    }
}
