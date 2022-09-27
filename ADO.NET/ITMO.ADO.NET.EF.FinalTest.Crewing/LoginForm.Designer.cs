namespace ITMO.ADO.NET.EF.FinalTest.Crewing
{
    partial class LoginForm
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin2 = new System.Windows.Forms.Button();
            this.buttonCloseLoginForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(50, 40);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(184, 27);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.Text = "User Name";
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(50, 92);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(184, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogin2
            // 
            this.buttonLogin2.Location = new System.Drawing.Point(50, 142);
            this.buttonLogin2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin2.Name = "buttonLogin2";
            this.buttonLogin2.Size = new System.Drawing.Size(185, 29);
            this.buttonLogin2.TabIndex = 2;
            this.buttonLogin2.Text = "Login";
            this.buttonLogin2.UseVisualStyleBackColor = true;
            this.buttonLogin2.Click += new System.EventHandler(this.buttonLogin2_Click);
            // 
            // buttonCloseLoginForm
            // 
            this.buttonCloseLoginForm.Location = new System.Drawing.Point(49, 193);
            this.buttonCloseLoginForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCloseLoginForm.Name = "buttonCloseLoginForm";
            this.buttonCloseLoginForm.Size = new System.Drawing.Size(185, 29);
            this.buttonCloseLoginForm.TabIndex = 3;
            this.buttonCloseLoginForm.Text = "Close";
            this.buttonCloseLoginForm.UseVisualStyleBackColor = true;
            this.buttonCloseLoginForm.Click += new System.EventHandler(this.buttonCloseLoginForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 260);
            this.Controls.Add(this.buttonCloseLoginForm);
            this.Controls.Add(this.buttonLogin2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Window";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin2;
        private System.Windows.Forms.Button buttonCloseLoginForm;
    }
}