using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MyClass

namespace ITMO.CSAppDev.Lab2.Exercise6.BiblWorm
{
    public partial class Form1 : Form
    {   // Library list
        List<MyClass.Item> its = new List<MyClass.Item>();
        // Control elements properties
        public string Author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title
        {
            get { return textBox2.Text; }
            set { textBox2.Text= value; }
        }
        public string Publisher
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public bool Availability
        {
            get { return (checkBox1.Checked); }
            set { checkBox1.Checked = value; }
        }
        public bool ReturnTime
        {
            get { return (checkBox2.Checked); }
            set { checkBox2.Checked = value; }
        }
        public bool SortInvNumber
        {
            get { return (checkBox3.Checked); }
            set { checkBox3.Checked = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Button Add handler
        private void button1_Click(object sender, EventArgs e)
        {   
            // Instance of class Book
            MyClass.Book b = new MyClass.Book(Author, Title, Publisher, Page, Year, InvNumber, Availability);
            //Check if the book has been returned in due time
            if (ReturnTime) b.ReturnSrok();
            //Calculation of the cost, taking into account the period of use of the book
            b.PriceBook(PeriodUse);
            //Add the book in the list
            its.Add(b);
            // At the end clear all the data in the fields
            Author = Title = Publisher = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Availability = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            // If checkbox 'Sort by inv number' is checked, let's sort
            if(SortInvNumber) its.Sort();
            StringBuilder sb = new StringBuilder();

            // Create a string of class StringBuilder.
            // Build a string with info for each item using cycle
            foreach(MyClass.Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            // Having built the string output it to richtextbox
            richTextBox1.Text = sb.ToString();
        }
    }
}
