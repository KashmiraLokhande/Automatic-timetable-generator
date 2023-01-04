namespace timetable2
{
    partial class adminmainpage
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
            this.btncourse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btngeneratett = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnslot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncourse
            // 
            this.btncourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncourse.Location = new System.Drawing.Point(335, 253);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(288, 41);
            this.btncourse.TabIndex = 0;
            this.btncourse.Text = "COURSE";
            this.btncourse.UseVisualStyleBackColor = true;
            this.btncourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(336, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "TEACHER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(335, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "CLASSROOM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngeneratett
            // 
            this.btngeneratett.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngeneratett.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratett.Location = new System.Drawing.Point(335, 525);
            this.btngeneratett.Name = "btngeneratett";
            this.btngeneratett.Size = new System.Drawing.Size(288, 41);
            this.btngeneratett.TabIndex = 3;
            this.btngeneratett.Text = "GENERATE TIMETABLE";
            this.btngeneratett.UseVisualStyleBackColor = true;
            this.btngeneratett.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlogout.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(335, 600);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(288, 41);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::timetable2.Properties.Resources.adminicon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(354, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 168);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnslot
            // 
            this.btnslot.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnslot.Location = new System.Drawing.Point(335, 455);
            this.btnslot.Name = "btnslot";
            this.btnslot.Size = new System.Drawing.Size(288, 41);
            this.btnslot.TabIndex = 6;
            this.btnslot.Text = "LECTURE SLOT";
            this.btnslot.UseVisualStyleBackColor = true;
            this.btnslot.Click += new System.EventHandler(this.btnlecture_Click);
            // 
            // adminmainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btnslot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btngeneratett);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncourse);
            this.Name = "adminmainpage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trialadminpage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncourse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btngeneratett;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnslot;
    }
}