namespace ITMO.WinForms.FinalTest
{
    partial class FormAddNew
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DiscountAddNew = new System.Windows.Forms.TextBox();
            this.textBox_PriceAddNew = new System.Windows.Forms.TextBox();
            this.textBox_QuantityAddNew = new System.Windows.Forms.TextBox();
            this.textBox_ProductNameAddNew = new System.Windows.Forms.TextBox();
            this.btnSaveAddNew = new System.Windows.Forms.Button();
            this.test_blockDataSet = new ITMO.WinForms.FinalTest.test_blockDataSet();
            this.t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t1TableAdapter = new ITMO.WinForms.FinalTest.test_blockDataSetTableAdapters.t1TableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Product Record";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_DiscountAddNew);
            this.groupBox1.Controls.Add(this.textBox_PriceAddNew);
            this.groupBox1.Controls.Add(this.textBox_QuantityAddNew);
            this.groupBox1.Controls.Add(this.textBox_ProductNameAddNew);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // textBox_DiscountAddNew
            // 
            this.textBox_DiscountAddNew.Location = new System.Drawing.Point(124, 152);
            this.textBox_DiscountAddNew.Name = "textBox_DiscountAddNew";
            this.textBox_DiscountAddNew.Size = new System.Drawing.Size(194, 34);
            this.textBox_DiscountAddNew.TabIndex = 4;
            // 
            // textBox_PriceAddNew
            // 
            this.textBox_PriceAddNew.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.t1BindingSource, "Price", true));
            this.textBox_PriceAddNew.Location = new System.Drawing.Point(124, 112);
            this.textBox_PriceAddNew.Name = "textBox_PriceAddNew";
            this.textBox_PriceAddNew.Size = new System.Drawing.Size(194, 34);
            this.textBox_PriceAddNew.TabIndex = 3;
            // 
            // textBox_QuantityAddNew
            // 
            this.textBox_QuantityAddNew.Location = new System.Drawing.Point(124, 72);
            this.textBox_QuantityAddNew.Name = "textBox_QuantityAddNew";
            this.textBox_QuantityAddNew.Size = new System.Drawing.Size(194, 34);
            this.textBox_QuantityAddNew.TabIndex = 2;
            // 
            // textBox_ProductNameAddNew
            // 
            this.textBox_ProductNameAddNew.Location = new System.Drawing.Point(124, 32);
            this.textBox_ProductNameAddNew.Name = "textBox_ProductNameAddNew";
            this.textBox_ProductNameAddNew.Size = new System.Drawing.Size(194, 34);
            this.textBox_ProductNameAddNew.TabIndex = 1;
            // 
            // btnSaveAddNew
            // 
            this.btnSaveAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveAddNew.Location = new System.Drawing.Point(18, 279);
            this.btnSaveAddNew.Name = "btnSaveAddNew";
            this.btnSaveAddNew.Size = new System.Drawing.Size(138, 41);
            this.btnSaveAddNew.TabIndex = 3;
            this.btnSaveAddNew.Text = "Save";
            this.btnSaveAddNew.UseVisualStyleBackColor = true;
            this.btnSaveAddNew.Click += new System.EventHandler(this.btnSaveAddNew_Click);
            // 
            // test_blockDataSet
            // 
            this.test_blockDataSet.DataSetName = "test_blockDataSet";
            this.test_blockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1BindingSource
            // 
            this.t1BindingSource.DataMember = "t1";
            this.t1BindingSource.DataSource = this.test_blockDataSet;
            // 
            // t1TableAdapter
            // 
            this.t1TableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(192, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 342);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveAddNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNew";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.FormAddNew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DiscountAddNew;
        private System.Windows.Forms.TextBox textBox_PriceAddNew;
        private System.Windows.Forms.TextBox textBox_QuantityAddNew;
        private System.Windows.Forms.TextBox textBox_ProductNameAddNew;
        private System.Windows.Forms.Button btnSaveAddNew;
        private test_blockDataSet test_blockDataSet;
        private System.Windows.Forms.BindingSource t1BindingSource;
        private test_blockDataSetTableAdapters.t1TableAdapter t1TableAdapter;
        private System.Windows.Forms.Button btnClose;
    }
}