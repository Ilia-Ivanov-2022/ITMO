namespace ITMO.ADO.NET.EF.FinalTest.Crewing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSeafarers = new System.Windows.Forms.DataGridView();
            this.dataGridViewVessels = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.comboBoxVessels = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddVsl = new System.Windows.Forms.Button();
            this.buttonEditVsl = new System.Windows.Forms.Button();
            this.buttonDeleteVsl = new System.Windows.Forms.Button();
            this.textBoxVslName = new System.Windows.Forms.TextBox();
            this.textBoxCrewingManager = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelSeafarerId = new System.Windows.Forms.Label();
            this.labelVesselAssigned = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelPsn = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelVslName = new System.Windows.Forms.Label();
            this.labelCrwngMng = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeafarers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVessels)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(423, 25);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 41);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Seafarer";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewSeafarers
            // 
            this.dataGridViewSeafarers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeafarers.Location = new System.Drawing.Point(1, 278);
            this.dataGridViewSeafarers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSeafarers.Name = "dataGridViewSeafarers";
            this.dataGridViewSeafarers.RowHeadersWidth = 51;
            this.dataGridViewSeafarers.RowTemplate.Height = 24;
            this.dataGridViewSeafarers.Size = new System.Drawing.Size(989, 284);
            this.dataGridViewSeafarers.TabIndex = 3;
            this.dataGridViewSeafarers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeafarers_CellClick);
            // 
            // dataGridViewVessels
            // 
            this.dataGridViewVessels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVessels.Location = new System.Drawing.Point(998, 278);
            this.dataGridViewVessels.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVessels.Name = "dataGridViewVessels";
            this.dataGridViewVessels.RowHeadersWidth = 51;
            this.dataGridViewVessels.RowTemplate.Height = 24;
            this.dataGridViewVessels.Size = new System.Drawing.Size(623, 284);
            this.dataGridViewVessels.TabIndex = 4;
            this.dataGridViewVessels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVessels_CellClick);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(720, 18);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(213, 27);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(720, 53);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(242, 27);
            this.textBoxLastName.TabIndex = 6;
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Location = new System.Drawing.Point(720, 88);
            this.textBoxDOB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(242, 27);
            this.textBoxDOB.TabIndex = 7;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(720, 123);
            this.textBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(242, 27);
            this.textBoxPosition.TabIndex = 8;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(720, 158);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(242, 27);
            this.textBoxHeight.TabIndex = 9;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(720, 193);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(242, 27);
            this.textBoxWeight.TabIndex = 10;
            // 
            // comboBoxVessels
            // 
            this.comboBoxVessels.FormattingEnabled = true;
            this.comboBoxVessels.Items.AddRange(new object[] {
            "Vessels"});
            this.comboBoxVessels.Location = new System.Drawing.Point(720, 227);
            this.comboBoxVessels.Name = "comboBoxVessels";
            this.comboBoxVessels.Size = new System.Drawing.Size(242, 28);
            this.comboBoxVessels.TabIndex = 11;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(423, 74);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(158, 41);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit Seafarer";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(423, 123);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 41);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete Seafarer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddVsl
            // 
            this.buttonAddVsl.Location = new System.Drawing.Point(1034, 28);
            this.buttonAddVsl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddVsl.Name = "buttonAddVsl";
            this.buttonAddVsl.Size = new System.Drawing.Size(158, 41);
            this.buttonAddVsl.TabIndex = 15;
            this.buttonAddVsl.Text = "Add Vessel";
            this.buttonAddVsl.UseVisualStyleBackColor = true;
            this.buttonAddVsl.Click += new System.EventHandler(this.buttonAddVsl_Click);
            // 
            // buttonEditVsl
            // 
            this.buttonEditVsl.Location = new System.Drawing.Point(1034, 84);
            this.buttonEditVsl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditVsl.Name = "buttonEditVsl";
            this.buttonEditVsl.Size = new System.Drawing.Size(158, 41);
            this.buttonEditVsl.TabIndex = 16;
            this.buttonEditVsl.Text = "Edit Vessel";
            this.buttonEditVsl.UseVisualStyleBackColor = true;
            this.buttonEditVsl.Click += new System.EventHandler(this.buttonEditVsl_Click);
            // 
            // buttonDeleteVsl
            // 
            this.buttonDeleteVsl.Location = new System.Drawing.Point(1034, 140);
            this.buttonDeleteVsl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteVsl.Name = "buttonDeleteVsl";
            this.buttonDeleteVsl.Size = new System.Drawing.Size(158, 41);
            this.buttonDeleteVsl.TabIndex = 17;
            this.buttonDeleteVsl.Text = "Delete Vessel";
            this.buttonDeleteVsl.UseVisualStyleBackColor = true;
            this.buttonDeleteVsl.Click += new System.EventHandler(this.buttonDeleteVsl_Click);
            // 
            // textBoxVslName
            // 
            this.textBoxVslName.Location = new System.Drawing.Point(1354, 32);
            this.textBoxVslName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVslName.Name = "textBoxVslName";
            this.textBoxVslName.Size = new System.Drawing.Size(242, 27);
            this.textBoxVslName.TabIndex = 18;
            // 
            // textBoxCrewingManager
            // 
            this.textBoxCrewingManager.Location = new System.Drawing.Point(1354, 88);
            this.textBoxCrewingManager.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCrewingManager.Name = "textBoxCrewingManager";
            this.textBoxCrewingManager.Size = new System.Drawing.Size(242, 27);
            this.textBoxCrewingManager.TabIndex = 19;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 22);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 41);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelSeafarerId
            // 
            this.labelSeafarerId.AutoSize = true;
            this.labelSeafarerId.Location = new System.Drawing.Point(940, 21);
            this.labelSeafarerId.Name = "labelSeafarerId";
            this.labelSeafarerId.Size = new System.Drawing.Size(22, 20);
            this.labelSeafarerId.TabIndex = 24;
            this.labelSeafarerId.Text = "Id";
            // 
            // labelVesselAssigned
            // 
            this.labelVesselAssigned.AutoSize = true;
            this.labelVesselAssigned.Location = new System.Drawing.Point(652, 230);
            this.labelVesselAssigned.Name = "labelVesselAssigned";
            this.labelVesselAssigned.Size = new System.Drawing.Size(60, 20);
            this.labelVesselAssigned.TabIndex = 25;
            this.labelVesselAssigned.Text = "Vessel";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(621, 21);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(92, 20);
            this.labelFirstName.TabIndex = 26;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(620, 56);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(91, 20);
            this.labelLastName.TabIndex = 27;
            this.labelLastName.Text = "Last Name";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(606, 91);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(105, 20);
            this.labelDOB.TabIndex = 28;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelPsn
            // 
            this.labelPsn.AutoSize = true;
            this.labelPsn.Location = new System.Drawing.Point(642, 126);
            this.labelPsn.Name = "labelPsn";
            this.labelPsn.Size = new System.Drawing.Size(69, 20);
            this.labelPsn.TabIndex = 29;
            this.labelPsn.Text = "Position";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(653, 161);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(58, 20);
            this.labelHeight.TabIndex = 30;
            this.labelHeight.Text = "Height";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(650, 196);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(61, 20);
            this.labelWeight.TabIndex = 31;
            this.labelWeight.Text = "Weight";
            // 
            // labelVslName
            // 
            this.labelVslName.AutoSize = true;
            this.labelVslName.Location = new System.Drawing.Point(1238, 38);
            this.labelVslName.Name = "labelVslName";
            this.labelVslName.Size = new System.Drawing.Size(109, 20);
            this.labelVslName.TabIndex = 32;
            this.labelVslName.Text = "Vessel Name";
            // 
            // labelCrwngMng
            // 
            this.labelCrwngMng.AutoSize = true;
            this.labelCrwngMng.Location = new System.Drawing.Point(1207, 91);
            this.labelCrwngMng.Name = "labelCrwngMng";
            this.labelCrwngMng.Size = new System.Drawing.Size(140, 20);
            this.labelCrwngMng.TabIndex = 33;
            this.labelCrwngMng.Text = "Crewing Manager";
            this.labelCrwngMng.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 562);
            this.Controls.Add(this.labelCrwngMng);
            this.Controls.Add(this.labelVslName);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelPsn);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelVesselAssigned);
            this.Controls.Add(this.labelSeafarerId);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxCrewingManager);
            this.Controls.Add(this.textBoxVslName);
            this.Controls.Add(this.buttonDeleteVsl);
            this.Controls.Add(this.buttonEditVsl);
            this.Controls.Add(this.buttonAddVsl);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxVessels);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dataGridViewVessels);
            this.Controls.Add(this.dataGridViewSeafarers);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Crewing Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeafarers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVessels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewSeafarers;
        private System.Windows.Forms.DataGridView dataGridViewVessels;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.ComboBox comboBoxVessels;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddVsl;
        private System.Windows.Forms.Button buttonEditVsl;
        private System.Windows.Forms.Button buttonDeleteVsl;
        private System.Windows.Forms.TextBox textBoxVslName;
        private System.Windows.Forms.TextBox textBoxCrewingManager;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelSeafarerId;
        private System.Windows.Forms.Label labelVesselAssigned;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelPsn;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelVslName;
        private System.Windows.Forms.Label labelCrwngMng;
    }
}

