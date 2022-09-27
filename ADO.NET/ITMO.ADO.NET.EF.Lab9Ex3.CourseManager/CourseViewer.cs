using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;


namespace ITMO.ADO.NET.EF.Lab9Ex3.CourseManager
{
    public partial class CourseViewer : Form
    {
        // Instance of ObjectContext.
        private SchoolEntities schoolContext;
        public CourseViewer()
        {
            InitializeComponent();
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            // Query Departments ordered by Name.

            //var departmentQuery = schoolContext.Departments.Include("Courses")
            //                        .ToList();

            var departmentQuery = from d in schoolContext.Departments.Include("Courses")
                                  orderby d.Name
                                  select d;
            // Display Names of Departments. Connect departmentList to DB.
            try
            {
                this.departmentList.DisplayMember = "Name";
                this.departmentList.DataSource = departmentQuery.ToList();
                    //((ObjectQuery)departmentQuery).Execute(MergeOption.AppendOnly);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataGridView GetCourseGridView()
        {
            return courseGridView;
        }

        // Display Courses for a selected Department.
        private void departmentList_SelectedIndexChanged(object sender, EventArgs e, DataGridView courseGridView)
        {
            try
            {
                Department department = (Department)this.departmentList.SelectedItem;

                courseGridView.DataSource = department.Courses;
                courseGridView.Columns["Department"].Visible = false;
                courseGridView.Columns["StudentGrades"].Visible = false;
                courseGridView.Columns["OnlineCourse"].Visible = false;
                courseGridView.Columns["OnsiteCourse"].Visible = false;
                courseGridView.Columns["People"].Visible = false;
                courseGridView.Columns["DepartmentId"].Visible = false;

                courseGridView.AllowUserToDeleteRows = false;
                courseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                schoolContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
            schoolContext.Dispose();
        }
    }
}
