namespace timetable2
{
    partial class course1
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
            this.lblcoursename = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblteacher = new System.Windows.Forms.Label();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.comboteacher = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbttDataSet1 = new timetable2.dbttDataSet1();
            this.courseTableAdapter = new timetable2.dbttDataSet1TableAdapters.courseTableAdapter();
            this.btninsertcourse = new System.Windows.Forms.Button();
            this.btnupdatecourse = new System.Windows.Forms.Button();
            this.btndeletecourse = new System.Windows.Forms.Button();
            this.rdnse = new System.Windows.Forms.RadioButton();
            this.rdnte = new System.Windows.Forms.RadioButton();
            this.rdnbe = new System.Windows.Forms.RadioButton();
            this.lblcourseid = new System.Windows.Forms.Label();
            this.txtcourseid = new System.Windows.Forms.TextBox();
            this.gridcourse = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbttDataSet3 = new timetable2.dbttDataSet3();
            this.courseTableAdapter1 = new timetable2.dbttDataSet3TableAdapters.courseTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(98, 111);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(140, 20);
            this.lblcoursename.TabIndex = 0;
            this.lblcoursename.Text = "COURSE NAME";
            this.lblcoursename.Click += new System.EventHandler(this.lblcoursename_Click);
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(98, 166);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(57, 20);
            this.lblyear.TabIndex = 1;
            this.lblyear.Text = "YEAR";
            this.lblyear.Click += new System.EventHandler(this.lblyear_Click);
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.Location = new System.Drawing.Point(98, 219);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(94, 20);
            this.lblteacher.TabIndex = 2;
            this.lblteacher.Text = "TEACHER";
            this.lblteacher.Click += new System.EventHandler(this.lblteacher_Click);
            // 
            // txtcoursename
            // 
            this.txtcoursename.Location = new System.Drawing.Point(269, 111);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(186, 22);
            this.txtcoursename.TabIndex = 3;
            this.txtcoursename.TextChanged += new System.EventHandler(this.txtcoursename_TextChanged);
            // 
            // comboteacher
            // 
            this.comboteacher.FormattingEnabled = true;
            this.comboteacher.Location = new System.Drawing.Point(269, 219);
            this.comboteacher.Name = "comboteacher";
            this.comboteacher.Size = new System.Drawing.Size(186, 24);
            this.comboteacher.TabIndex = 7;
            this.comboteacher.SelectedIndexChanged += new System.EventHandler(this.comboteacher_SelectedIndexChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.dbttDataSet1;
            // 
            // dbttDataSet1
            // 
            this.dbttDataSet1.DataSetName = "dbttDataSet1";
            this.dbttDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // btninsertcourse
            // 
            this.btninsertcourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsertcourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertcourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninsertcourse.Location = new System.Drawing.Point(303, 269);
            this.btninsertcourse.Name = "btninsertcourse";
            this.btninsertcourse.Size = new System.Drawing.Size(118, 35);
            this.btninsertcourse.TabIndex = 16;
            this.btninsertcourse.Text = "INSERT";
            this.btninsertcourse.UseVisualStyleBackColor = false;
            this.btninsertcourse.Click += new System.EventHandler(this.btninsertcourse_Click);
            // 
            // btnupdatecourse
            // 
            this.btnupdatecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdatecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdatecourse.Location = new System.Drawing.Point(475, 269);
            this.btnupdatecourse.Name = "btnupdatecourse";
            this.btnupdatecourse.Size = new System.Drawing.Size(110, 35);
            this.btnupdatecourse.TabIndex = 17;
            this.btnupdatecourse.Text = "UPDATE";
            this.btnupdatecourse.UseVisualStyleBackColor = false;
            this.btnupdatecourse.Click += new System.EventHandler(this.btnupdatecourse_Click);
            // 
            // btndeletecourse
            // 
            this.btndeletecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndeletecourse.Location = new System.Drawing.Point(646, 269);
            this.btndeletecourse.Name = "btndeletecourse";
            this.btndeletecourse.Size = new System.Drawing.Size(95, 35);
            this.btndeletecourse.TabIndex = 18;
            this.btndeletecourse.Text = "DELETE";
            this.btndeletecourse.UseVisualStyleBackColor = false;
            this.btndeletecourse.Click += new System.EventHandler(this.btndeletecourse_Click);
            // 
            // rdnse
            // 
            this.rdnse.AutoSize = true;
            this.rdnse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnse.Location = new System.Drawing.Point(269, 162);
            this.rdnse.Name = "rdnse";
            this.rdnse.Size = new System.Drawing.Size(59, 24);
            this.rdnse.TabIndex = 19;
            this.rdnse.TabStop = true;
            this.rdnse.Text = "S.E.";
            this.rdnse.UseVisualStyleBackColor = true;
            this.rdnse.CheckedChanged += new System.EventHandler(this.rdnse_CheckedChanged);
            // 
            // rdnte
            // 
            this.rdnte.AutoSize = true;
            this.rdnte.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnte.Location = new System.Drawing.Point(393, 162);
            this.rdnte.Name = "rdnte";
            this.rdnte.Size = new System.Drawing.Size(62, 24);
            this.rdnte.TabIndex = 20;
            this.rdnte.TabStop = true;
            this.rdnte.Text = "T.E.";
            this.rdnte.UseVisualStyleBackColor = true;
            this.rdnte.CheckedChanged += new System.EventHandler(this.rdnbe_CheckedChanged);
            // 
            // rdnbe
            // 
            this.rdnbe.AutoSize = true;
            this.rdnbe.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnbe.Location = new System.Drawing.Point(548, 162);
            this.rdnbe.Name = "rdnbe";
            this.rdnbe.Size = new System.Drawing.Size(61, 24);
            this.rdnbe.TabIndex = 21;
            this.rdnbe.TabStop = true;
            this.rdnbe.Text = "B.E.";
            this.rdnbe.UseVisualStyleBackColor = true;
            this.rdnbe.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblcourseid
            // 
            this.lblcourseid.AutoSize = true;
            this.lblcourseid.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourseid.Location = new System.Drawing.Point(98, 64);
            this.lblcourseid.Name = "lblcourseid";
            this.lblcourseid.Size = new System.Drawing.Size(107, 20);
            this.lblcourseid.TabIndex = 22;
            this.lblcourseid.Text = "COURSE ID";
            this.lblcourseid.Click += new System.EventHandler(this.lblcourseid_Click);
            // 
            // txtcourseid
            // 
            this.txtcourseid.Location = new System.Drawing.Point(269, 62);
            this.txtcourseid.Name = "txtcourseid";
            this.txtcourseid.Size = new System.Drawing.Size(186, 22);
            this.txtcourseid.TabIndex = 23;
            this.txtcourseid.TextChanged += new System.EventHandler(this.txtcourseid_TextChanged);
            // 
            // gridcourse
            // 
            this.gridcourse.AllowUserToAddRows = false;
            this.gridcourse.AllowUserToDeleteRows = false;
            this.gridcourse.AutoGenerateColumns = false;
            this.gridcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn});
            this.gridcourse.DataSource = this.courseBindingSource1;
            this.gridcourse.Location = new System.Drawing.Point(-1, 400);
            this.gridcourse.Name = "gridcourse";
            this.gridcourse.RowTemplate.Height = 24;
            this.gridcourse.Size = new System.Drawing.Size(1000, 400);
            this.gridcourse.TabIndex = 24;
            this.gridcourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcourse_CellContentClick);
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "cid";
            this.cidDataGridViewTextBoxColumn.HeaderText = "cid";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "coursename";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "coursename";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "teacher";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "course";
            this.courseBindingSource1.DataSource = this.dbttDataSet3;
            // 
            // dbttDataSet3
            // 
            this.dbttDataSet3.DataSetName = "dbttDataSet3";
            this.dbttDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.pictureBox1.Image = global::timetable2.Properties.Resources.backicon;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // course1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridcourse);
            this.Controls.Add(this.txtcourseid);
            this.Controls.Add(this.lblcourseid);
            this.Controls.Add(this.rdnbe);
            this.Controls.Add(this.rdnte);
            this.Controls.Add(this.rdnse);
            this.Controls.Add(this.btndeletecourse);
            this.Controls.Add(this.btnupdatecourse);
            this.Controls.Add(this.btninsertcourse);
            this.Controls.Add(this.comboteacher);
            this.Controls.Add(this.txtcoursename);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblcoursename);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "course1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "course1";
            this.Load += new System.EventHandler(this.course1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.ComboBox comboteacher;
        private dbttDataSet1 dbttDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private dbttDataSet1TableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Button btninsertcourse;
        private System.Windows.Forms.Button btnupdatecourse;
        private System.Windows.Forms.Button btndeletecourse;
        private System.Windows.Forms.RadioButton rdnse;
        private System.Windows.Forms.RadioButton rdnte;
        private System.Windows.Forms.RadioButton rdnbe;
        private System.Windows.Forms.Label lblcourseid;
        private System.Windows.Forms.TextBox txtcourseid;
        private System.Windows.Forms.DataGridView gridcourse;
        private dbttDataSet3 dbttDataSet3;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private dbttDataSet3TableAdapters.courseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}