namespace timetable2
{
    partial class admingeneratett
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
            this.btnyearwise = new System.Windows.Forms.Button();
            this.btnfacultywise = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnyearwise
            // 
            this.btnyearwise.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyearwise.Location = new System.Drawing.Point(371, 319);
            this.btnyearwise.Name = "btnyearwise";
            this.btnyearwise.Size = new System.Drawing.Size(253, 54);
            this.btnyearwise.TabIndex = 0;
            this.btnyearwise.Text = "YEARWISE";
            this.btnyearwise.UseVisualStyleBackColor = true;
            this.btnyearwise.Click += new System.EventHandler(this.btnyearwise_Click);
            // 
            // btnfacultywise
            // 
            this.btnfacultywise.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacultywise.Location = new System.Drawing.Point(371, 471);
            this.btnfacultywise.Name = "btnfacultywise";
            this.btnfacultywise.Size = new System.Drawing.Size(253, 54);
            this.btnfacultywise.TabIndex = 1;
            this.btnfacultywise.Text = "FACULTYWISE";
            this.btnfacultywise.UseVisualStyleBackColor = true;
            this.btnfacultywise.Click += new System.EventHandler(this.btnfacultywise_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::timetable2.Properties.Resources.Logomakr_0Dv9VH;
            this.pictureBox1.Location = new System.Drawing.Point(136, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.pictureBox2.Image = global::timetable2.Properties.Resources.backicon;
            this.pictureBox2.Location = new System.Drawing.Point(25, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // admingeneratett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnfacultywise);
            this.Controls.Add(this.btnyearwise);
            this.Name = "admingeneratett";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admingeneratett";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyearwise;
        private System.Windows.Forms.Button btnfacultywise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}