namespace ITMO.CSAppDev.Lab5.Exercise3.WinAnim
{
    partial class FormAnimation
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
            this.btnAW_BLEND = new System.Windows.Forms.Button();
            this.btnHOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnCenter_AW_SLIDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAW_BLEND
            // 
            this.btnAW_BLEND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAW_BLEND.Location = new System.Drawing.Point(25, 29);
            this.btnAW_BLEND.Name = "btnAW_BLEND";
            this.btnAW_BLEND.Size = new System.Drawing.Size(124, 44);
            this.btnAW_BLEND.TabIndex = 0;
            this.btnAW_BLEND.Text = "Emerging";
            this.btnAW_BLEND.UseVisualStyleBackColor = true;
            this.btnAW_BLEND.Click += new System.EventHandler(this.btnAW_BLEND_Click);
            // 
            // btnHOR_AW_SLIDE
            // 
            this.btnHOR_AW_SLIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHOR_AW_SLIDE.Location = new System.Drawing.Point(25, 101);
            this.btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
            this.btnHOR_AW_SLIDE.Size = new System.Drawing.Size(124, 44);
            this.btnHOR_AW_SLIDE.TabIndex = 1;
            this.btnHOR_AW_SLIDE.Text = "Sliding";
            this.btnHOR_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btnHOR_AW_SLIDE.Click += new System.EventHandler(this.btnHOR_AW_SLIDE_Click);
            // 
            // btnCenter_AW_SLIDE
            // 
            this.btnCenter_AW_SLIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCenter_AW_SLIDE.Location = new System.Drawing.Point(25, 171);
            this.btnCenter_AW_SLIDE.Name = "btnCenter_AW_SLIDE";
            this.btnCenter_AW_SLIDE.Size = new System.Drawing.Size(124, 44);
            this.btnCenter_AW_SLIDE.TabIndex = 2;
            this.btnCenter_AW_SLIDE.Text = "Extending";
            this.btnCenter_AW_SLIDE.UseVisualStyleBackColor = true;
            this.btnCenter_AW_SLIDE.Click += new System.EventHandler(this.btnCenter_AW_SLIDE_Click);
            // 
            // FormAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCenter_AW_SLIDE);
            this.Controls.Add(this.btnHOR_AW_SLIDE);
            this.Controls.Add(this.btnAW_BLEND);
            this.Name = "FormAnimation";
            this.Text = "Form Animation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAW_BLEND;
        private System.Windows.Forms.Button btnHOR_AW_SLIDE;
        private System.Windows.Forms.Button btnCenter_AW_SLIDE;
    }
}

