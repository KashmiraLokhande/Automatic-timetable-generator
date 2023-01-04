namespace timetable2
{
    partial class adminteacher
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
            this.gridcourse = new System.Windows.Forms.DataGridView();
            this.txttid = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.btndeletecourse = new System.Windows.Forms.Button();
            this.btnupdatecourse = new System.Windows.Forms.Button();
            this.btninsertcourse = new System.Windows.Forms.Button();
            this.combopost = new System.Windows.Forms.ComboBox();
            this.txttname = new System.Windows.Forms.TextBox();
            this.lblteacher = new System.Windows.Forms.Label();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdnbe = new System.Windows.Forms.RadioButton();
            this.rdnte = new System.Windows.Forms.RadioButton();
            this.rdnse = new System.Windows.Forms.RadioButton();
            this.lblyear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.dbttDataSet14 = new timetable2.dbttDataSet14();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new timetable2.dbttDataSet14TableAdapters.teacherTableAdapter();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcourse
            // 
            this.gridcourse.AllowUserToAddRows = false;
            this.gridcourse.AllowUserToDeleteRows = false;
            this.gridcourse.AutoGenerateColumns = false;
            this.gridcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.tnameDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.gridcourse.DataSource = this.teacherBindingSource;
            this.gridcourse.Location = new System.Drawing.Point(-4, 393);
            this.gridcourse.Name = "gridcourse";
            this.gridcourse.ReadOnly = true;
            this.gridcourse.RowTemplate.Height = 24;
            this.gridcourse.Size = new System.Drawing.Size(986, 364);
            this.gridcourse.TabIndex = 39;
            // 
            // txttid
            // 
            this.txttid.Location = new System.Drawing.Point(302, 36);
            this.txttid.Name = "txttid";
            this.txttid.Size = new System.Drawing.Size(186, 22);
            this.txttid.TabIndex = 38;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(131, 36);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(81, 20);
            this.lbluserid.TabIndex = 37;
            this.lbluserid.Text = "USER ID";
            // 
            // btndeletecourse
            // 
            this.btndeletecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndeletecourse.Location = new System.Drawing.Point(683, 325);
            this.btndeletecourse.Name = "btndeletecourse";
            this.btndeletecourse.Size = new System.Drawing.Size(114, 35);
            this.btndeletecourse.TabIndex = 33;
            this.btndeletecourse.Text = "DELETE";
            this.btndeletecourse.UseVisualStyleBackColor = false;
            this.btndeletecourse.Click += new System.EventHandler(this.btndeletecourse_Click);
            // 
            // btnupdatecourse
            // 
            this.btnupdatecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdatecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdatecourse.Location = new System.Drawing.Point(512, 325);
            this.btnupdatecourse.Name = "btnupdatecourse";
            this.btnupdatecourse.Size = new System.Drawing.Size(123, 35);
            this.btnupdatecourse.TabIndex = 32;
            this.btnupdatecourse.Text = "UPDATE";
            this.btnupdatecourse.UseVisualStyleBackColor = false;
            this.btnupdatecourse.Click += new System.EventHandler(this.btnupdatecourse_Click);
            // 
            // btninsertcourse
            // 
            this.btninsertcourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsertcourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertcourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninsertcourse.Location = new System.Drawing.Point(340, 325);
            this.btninsertcourse.Name = "btninsertcourse";
            this.btninsertcourse.Size = new System.Drawing.Size(148, 35);
            this.btninsertcourse.TabIndex = 31;
            this.btninsertcourse.Text = "INSERT";
            this.btninsertcourse.UseVisualStyleBackColor = false;
            this.btninsertcourse.Click += new System.EventHandler(this.btninsertcourse_Click);
            // 
            // combopost
            // 
            this.combopost.FormattingEnabled = true;
            this.combopost.Items.AddRange(new object[] {
            "ASSOCIATE PROFESSOR",
            "ASSITANT PROFESSOR",
            "HEAD PROFESSOR"});
            this.combopost.Location = new System.Drawing.Point(302, 275);
            this.combopost.Name = "combopost";
            this.combopost.Size = new System.Drawing.Size(186, 24);
            this.combopost.TabIndex = 30;
            // 
            // txttname
            // 
            this.txttname.Location = new System.Drawing.Point(302, 144);
            this.txttname.Name = "txttname";
            this.txttname.Size = new System.Drawing.Size(186, 22);
            this.txttname.TabIndex = 29;
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.Location = new System.Drawing.Point(131, 275);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(56, 20);
            this.lblteacher.TabIndex = 28;
            this.lblteacher.Text = "POST";
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(131, 144);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(153, 20);
            this.lblcoursename.TabIndex = 26;
            this.lblcoursename.Text = "TEACHER NAME";
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
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdnbe
            // 
            this.rdnbe.AutoSize = true;
            this.rdnbe.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnbe.Location = new System.Drawing.Point(565, 207);
            this.rdnbe.Name = "rdnbe";
            this.rdnbe.Size = new System.Drawing.Size(61, 24);
            this.rdnbe.TabIndex = 44;
            this.rdnbe.TabStop = true;
            this.rdnbe.Text = "B.E.";
            this.rdnbe.UseVisualStyleBackColor = true;
            this.rdnbe.CheckedChanged += new System.EventHandler(this.rdnbe_CheckedChanged);
            // 
            // rdnte
            // 
            this.rdnte.AutoSize = true;
            this.rdnte.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnte.Location = new System.Drawing.Point(426, 205);
            this.rdnte.Name = "rdnte";
            this.rdnte.Size = new System.Drawing.Size(62, 24);
            this.rdnte.TabIndex = 43;
            this.rdnte.TabStop = true;
            this.rdnte.Text = "T.E.";
            this.rdnte.UseVisualStyleBackColor = true;
            this.rdnte.CheckedChanged += new System.EventHandler(this.rdnte_CheckedChanged);
            // 
            // rdnse
            // 
            this.rdnse.AutoSize = true;
            this.rdnse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnse.Location = new System.Drawing.Point(302, 205);
            this.rdnse.Name = "rdnse";
            this.rdnse.Size = new System.Drawing.Size(59, 24);
            this.rdnse.TabIndex = 42;
            this.rdnse.TabStop = true;
            this.rdnse.Text = "S.E.";
            this.rdnse.UseVisualStyleBackColor = true;
            this.rdnse.CheckedChanged += new System.EventHandler(this.rdnse_CheckedChanged);
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(131, 209);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(57, 20);
            this.lblyear.TabIndex = 41;
            this.lblyear.Text = "YEAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "PASSWORD";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(302, 89);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(186, 22);
            this.txtpass.TabIndex = 46;
            // 
            // dbttDataSet14
            // 
            this.dbttDataSet14.DataSetName = "dbttDataSet14";
            this.dbttDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.dbttDataSet14;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "tid";
            this.tidDataGridViewTextBoxColumn.HeaderText = "tid";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tnameDataGridViewTextBoxColumn
            // 
            this.tnameDataGridViewTextBoxColumn.DataPropertyName = "tname";
            this.tnameDataGridViewTextBoxColumn.HeaderText = "tname";
            this.tnameDataGridViewTextBoxColumn.Name = "tnameDataGridViewTextBoxColumn";
            this.tnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "post";
            this.postDataGridViewTextBoxColumn.HeaderText = "post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdnbe);
            this.Controls.Add(this.rdnte);
            this.Controls.Add(this.rdnse);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridcourse);
            this.Controls.Add(this.txttid);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.btndeletecourse);
            this.Controls.Add(this.btnupdatecourse);
            this.Controls.Add(this.btninsertcourse);
            this.Controls.Add(this.combopost);
            this.Controls.Add(this.txttname);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.lblcoursename);
            this.Name = "adminteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminteacher";
            this.Load += new System.EventHandler(this.adminteacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridcourse;
        private System.Windows.Forms.TextBox txttid;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Button btndeletecourse;
        private System.Windows.Forms.Button btnupdatecourse;
        private System.Windows.Forms.Button btninsertcourse;
        private System.Windows.Forms.ComboBox combopost;
        private System.Windows.Forms.TextBox txttname;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.RadioButton rdnbe;
        private System.Windows.Forms.RadioButton rdnte;
        private System.Windows.Forms.RadioButton rdnse;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private dbttDataSet14 dbttDataSet14;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private dbttDataSet14TableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}