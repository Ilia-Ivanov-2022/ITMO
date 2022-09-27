using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ITMO.ADO.NET.EF.FinalTest.Crewing
{
    public partial class MainForm : Form
    {
        List<Vessel> vessels = new List<Vessel>();
        List<Seafarer> seafares = new List<Seafarer>();
        public MainForm()
        {
            InitializeComponent();
        }

        // GENERAL SECTION
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new CrewingContext())
            {
                // Connects to DB.
                vessels.AddRange(ctx.Vessels);
                seafares.AddRange(ctx.Seafarers);
                // Populate combox with Vessels Names.
                comboBoxVessels.Items.AddRange(ctx.Vessels.ToArray());
            }
            // Populate data grids.
            dataGridViewVessels.DataSource = vessels.ToList();
            dataGridViewSeafarers.DataSource = seafares.ToList();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OutputSeafarerTable()
        {
            using(var ctx = new CrewingContext())
            {
                dataGridViewSeafarers.DataSource = ctx.Seafarers.ToList();
            }
            
        }

        // SEAFARERS SECTION
        // Add a Seafarer.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using(var ctx = new CrewingContext())
            {
                if (textBoxFirstName.Text == String.Empty) return;
                Seafarer seafarer = new Seafarer()
                {
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    DateOfBirth = DateTime.Parse(textBoxDOB.Text),
                    Position = textBoxPosition.Text,
                    Height = decimal.Parse(textBoxHeight.Text),
                    Weight = float.Parse(textBoxWeight.Text),
                    Vessel = (Vessel)comboBoxVessels.SelectedItem
                };
                ctx.Seafarers.Add(seafarer);
                ctx.SaveChanges();
                dataGridViewSeafarers.DataSource = ctx.Seafarers.ToList();
                MessageBox.Show("Seafarer added");
            }
        }
        // Selected row in dataGridView.
        private void dataGridViewSeafarers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seafarer seafarer = new Seafarer();
                if (dataGridViewSeafarers.CurrentRow == null) return;
                seafarer = dataGridViewSeafarers.CurrentRow.DataBoundItem as Seafarer;
                if (seafarer == null) return;

                labelSeafarerId.Text = Convert.ToString(seafarer.SeafarerId);
                textBoxFirstName.Text = seafarer.FirstName;
                textBoxLastName.Text = seafarer.LastName;
                textBoxDOB.Text = seafarer.DateOfBirth.ToString();
                textBoxPosition.Text = seafarer.Position;
                textBoxHeight.Text = seafarer.Height.ToString();
                textBoxWeight.Text = seafarer.Weight.ToString();
                comboBoxVessels.SelectedText = seafarer.Vessel.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Edit Seafarer.
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Seafarer seafarer = new Seafarer();
            using (var ctx = new CrewingContext())
            {
                if (labelSeafarerId.Text == String.Empty) return;

                var sfrrId = Convert.ToInt32(labelSeafarerId.Text);
                seafarer = ctx.Seafarers.Find(sfrrId);
                if(seafarer == null) return;

                seafarer.FirstName = textBoxFirstName.Text;
                seafarer.LastName = textBoxLastName.Text;
                seafarer.DateOfBirth = DateTime.Parse(textBoxDOB.Text);
                seafarer.Position = textBoxPosition.Text;
                seafarer.Height = decimal.Parse(textBoxHeight.Text);
                seafarer.Weight = float.Parse(textBoxWeight.Text);
                seafarer.Vessel = (Vessel)comboBoxVessels.SelectedItem;

                ctx.Entry(seafarer).State = EntityState.Modified;
                ctx.SaveChanges();
                dataGridViewSeafarers.DataSource = ctx.Seafarers.ToList();
            }
        }

        // Delete Seafarer.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using(CrewingContext ctx = new CrewingContext())
            {
                if (textBoxFirstName.Text == String.Empty) return;
                var id = Convert.ToInt32(labelSeafarerId.Text);
                var seafarer = ctx.Seafarers.Find(id);

                ctx.Entry(seafarer).State = EntityState.Deleted;
                ctx.SaveChanges();
                OutputSeafarerTable();
            }
            
        }
        
        

        // VESSEL SECTION
        // Add a vessel.
        private void buttonAddVsl_Click(object sender, EventArgs e)
        {
            using (var ctx = new CrewingContext())
            {
                Vessel vsl = new Vessel()
                {
                    VesselName = textBoxVslName.Text,
                    CrewingManager = textBoxCrewingManager.Text,
                };
                var dbVslName = ctx.Vessels.Find(vsl.VesselName);
                if (dbVslName != null) return;
                
                ctx.Vessels.Add(vsl);
                MessageBox.Show("Vessel added");
                ctx.SaveChanges();
                   
            }
        }
        
        // Select row in a dataFridView.
        private void dataGridViewVessels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVessels == null) return;
            var vessel = dataGridViewVessels.CurrentRow.DataBoundItem as Vessel;
            if(vessel == null) return;

            vessel.VesselName = textBoxVslName.Text;
            vessel.CrewingManager = textBoxCrewingManager.Text;
        }
        // Edit a vessel.
        private void buttonEditVsl_Click(object sender, EventArgs e)
        {
            using(var ctx = new CrewingContext())
            {
                var vslName = textBoxVslName.Text;
                var vsl = ctx.Vessels.Find(vslName);
                if (vsl == null) return;

                vsl.VesselName = textBoxVslName.Text;
                vsl.CrewingManager = textBoxCrewingManager.Text;

                ctx.Entry(vsl).State = EntityState.Modified;
                ctx.SaveChanges();
                dataGridViewVessels.DataSource = ctx.Vessels.ToList();
            }
        }
        // Delete a vessel.
        private void buttonDeleteVsl_Click(object sender, EventArgs e)
        {
            using (var ctx = new CrewingContext())
            {
                var vslName = textBoxVslName.Text;
                var vsl = ctx.Vessels.Find(vslName);
                if (vsl == null) return;

                ctx.Entry(vsl).State = EntityState.Deleted;
                ctx.SaveChanges();
                dataGridViewVessels.DataSource = ctx.Vessels.ToList();
            }
        }
    }
}
