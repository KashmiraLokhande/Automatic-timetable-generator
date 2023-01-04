namespace timetable2
{
    partial class login
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
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.comboBoxcategory = new System.Windows.Forms.ComboBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelstudtechlogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelstudtechlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.BackColor = System.Drawing.SystemColors.Control;
            this.lbluserid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbluserid.Location = new System.Drawing.Point(150, 153);
            this.lbluserid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Padding = new System.Windows.Forms.Padding(19, 2, 3, 2);
            this.lbluserid.Size = new System.Drawing.Size(75, 23);
            this.lbluserid.TabIndex = 0;
            this.lbluserid.Text = "UserID";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblpassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpassword.Location = new System.Drawing.Point(152, 202);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblpassword.Size = new System.Drawing.Size(77, 23);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnlogin.Location = new System.Drawing.Point(351, 308);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(132, 36);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(351, 150);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(4);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(132, 22);
            this.txtuserid.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(351, 199);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(132, 22);
            this.txtpassword.TabIndex = 4;
            // 
            // comboBoxcategory
            // 
            this.comboBoxcategory.FormattingEnabled = true;
            this.comboBoxcategory.Items.AddRange(new object[] {
            "Admin",
            "Student",
            "Teacher"});
            this.comboBoxcategory.Location = new System.Drawing.Point(351, 249);
            this.comboBoxcategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxcategory.Name = "comboBoxcategory";
            this.comboBoxcategory.Size = new System.Drawing.Size(160, 24);
            this.comboBoxcategory.TabIndex = 12;
            this.comboBoxcategory.Text = "Select User";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.BackColor = System.Drawing.SystemColors.Control;
            this.lblcategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcategory.Location = new System.Drawing.Point(152, 252);
            this.lblcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblcategory.Size = new System.Drawing.Size(73, 23);
            this.lblcategory.TabIndex = 13;
            this.lblcategory.Text = "Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::timetable2.Properties.Resources.Logomakr_6RGou6;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panelstudtechlogin
            // 
            this.panelstudtechlogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelstudtechlogin.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.panelstudtechlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelstudtechlogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelstudtechlogin.Controls.Add(this.pictureBox1);
            this.panelstudtechlogin.Controls.Add(this.lblcategory);
            this.panelstudtechlogin.Controls.Add(this.comboBoxcategory);
            this.panelstudtechlogin.Controls.Add(this.txtpassword);
            this.panelstudtechlogin.Controls.Add(this.txtuserid);
            this.panelstudtechlogin.Controls.Add(this.btnlogin);
            this.panelstudtechlogin.Controls.Add(this.lblpassword);
            this.panelstudtechlogin.Controls.Add(this.lbluserid);
            this.panelstudtechlogin.Location = new System.Drawing.Point(150, 180);
            this.panelstudtechlogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelstudtechlogin.Name = "panelstudtechlogin";
            this.panelstudtechlogin.Size = new System.Drawing.Size(638, 381);
            this.panelstudtechlogin.TabIndex = 2;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panelstudtechlogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studtechlogin";
            this.Load += new System.EventHandler(this.studtechlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelstudtechlogin.ResumeLayout(false);
            this.panelstudtechlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox comboBoxcategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelstudtechlogin;
    }
}