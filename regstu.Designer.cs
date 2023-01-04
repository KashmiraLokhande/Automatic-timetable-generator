namespace timetable2
{
    partial class regstu
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdnbe = new System.Windows.Forms.RadioButton();
            this.rdnte = new System.Windows.Forms.RadioButton();
            this.rdnse = new System.Windows.Forms.RadioButton();
            this.lblyear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttid = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.lblcpass = new System.Windows.Forms.Label();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.btndeletecourse = new System.Windows.Forms.Button();
            this.btnupdatecourse = new System.Windows.Forms.Button();
            this.btninsertcourse = new System.Windows.Forms.Button();
            this.gridstud = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbttDataSet19 = new timetable2.dbttDataSet19();
            this.studentTableAdapter = new timetable2.dbttDataSet19TableAdapters.studentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridstud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(302, 89);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(186, 22);
            this.txtpass.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "PASSWORD";
            // 
            // rdnbe
            // 
            this.rdnbe.AutoSize = true;
            this.rdnbe.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnbe.Location = new System.Drawing.Point(565, 262);
            this.rdnbe.Name = "rdnbe";
            this.rdnbe.Size = new System.Drawing.Size(61, 24);
            this.rdnbe.TabIndex = 55;
            this.rdnbe.TabStop = true;
            this.rdnbe.Text = "B.E.";
            this.rdnbe.UseVisualStyleBackColor = true;
            // 
            // rdnte
            // 
            this.rdnte.AutoSize = true;
            this.rdnte.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnte.Location = new System.Drawing.Point(426, 260);
            this.rdnte.Name = "rdnte";
            this.rdnte.Size = new System.Drawing.Size(62, 24);
            this.rdnte.TabIndex = 54;
            this.rdnte.TabStop = true;
            this.rdnte.Text = "T.E.";
            this.rdnte.UseVisualStyleBackColor = true;
            // 
            // rdnse
            // 
            this.rdnse.AutoSize = true;
            this.rdnse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnse.Location = new System.Drawing.Point(302, 260);
            this.rdnse.Name = "rdnse";
            this.rdnse.Size = new System.Drawing.Size(59, 24);
            this.rdnse.TabIndex = 53;
            this.rdnse.TabStop = true;
            this.rdnse.Text = "S.E.";
            this.rdnse.UseVisualStyleBackColor = true;
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(131, 264);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(57, 20);
            this.lblyear.TabIndex = 52;
            this.lblyear.Text = "YEAR";
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
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txttid
            // 
            this.txttid.Location = new System.Drawing.Point(302, 36);
            this.txttid.Name = "txttid";
            this.txttid.Size = new System.Drawing.Size(186, 22);
            this.txttid.TabIndex = 50;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(131, 36);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(81, 20);
            this.lbluserid.TabIndex = 49;
            this.lbluserid.Text = "USER ID";
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(302, 210);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(186, 22);
            this.txtsname.TabIndex = 48;
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(131, 210);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(153, 20);
            this.lblcoursename.TabIndex = 47;
            this.lblcoursename.Text = "STUDENT NAME";
            // 
            // lblcpass
            // 
            this.lblcpass.AutoSize = true;
            this.lblcpass.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpass.Location = new System.Drawing.Point(78, 152);
            this.lblcpass.Name = "lblcpass";
            this.lblcpass.Size = new System.Drawing.Size(206, 20);
            this.lblcpass.TabIndex = 58;
            this.lblcpass.Text = "CONFORM PASSWORD";
            // 
            // txtcpass
            // 
            this.txtcpass.Location = new System.Drawing.Point(302, 150);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.Size = new System.Drawing.Size(186, 22);
            this.txtcpass.TabIndex = 59;
            // 
            // btndeletecourse
            // 
            this.btndeletecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndeletecourse.Location = new System.Drawing.Point(593, 303);
            this.btndeletecourse.Name = "btndeletecourse";
            this.btndeletecourse.Size = new System.Drawing.Size(114, 35);
            this.btndeletecourse.TabIndex = 62;
            this.btndeletecourse.Text = "DELETE";
            this.btndeletecourse.UseVisualStyleBackColor = false;
            this.btndeletecourse.Click += new System.EventHandler(this.btndeletecourse_Click);
            // 
            // btnupdatecourse
            // 
            this.btnupdatecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdatecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdatecourse.Location = new System.Drawing.Point(422, 303);
            this.btnupdatecourse.Name = "btnupdatecourse";
            this.btnupdatecourse.Size = new System.Drawing.Size(123, 35);
            this.btnupdatecourse.TabIndex = 61;
            this.btnupdatecourse.Text = "UPDATE";
            this.btnupdatecourse.UseVisualStyleBackColor = false;
            this.btnupdatecourse.Click += new System.EventHandler(this.btnupdatecourse_Click);
            // 
            // btninsertcourse
            // 
            this.btninsertcourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsertcourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertcourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninsertcourse.Location = new System.Drawing.Point(250, 303);
            this.btninsertcourse.Name = "btninsertcourse";
            this.btninsertcourse.Size = new System.Drawing.Size(148, 35);
            this.btninsertcourse.TabIndex = 60;
            this.btninsertcourse.Text = "INSERT";
            this.btninsertcourse.UseVisualStyleBackColor = false;
            this.btninsertcourse.Click += new System.EventHandler(this.btninsertcourse_Click);
            // 
            // gridstud
            // 
            this.gridstud.AutoGenerateColumns = false;
            this.gridstud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridstud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.cpassDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn});
            this.gridstud.DataSource = this.studentBindingSource;
            this.gridstud.Location = new System.Drawing.Point(-3, 354);
            this.gridstud.Name = "gridstud";
            this.gridstud.RowTemplate.Height = 24;
            this.gridstud.Size = new System.Drawing.Size(932, 252);
            this.gridstud.TabIndex = 63;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // cpassDataGridViewTextBoxColumn
            // 
            this.cpassDataGridViewTextBoxColumn.DataPropertyName = "cpass";
            this.cpassDataGridViewTextBoxColumn.HeaderText = "cpass";
            this.cpassDataGridViewTextBoxColumn.Name = "cpassDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.dbttDataSet19;
            // 
            // dbttDataSet19
            // 
            this.dbttDataSet19.DataSetName = "dbttDataSet19";
            this.dbttDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // regstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 605);
            this.Controls.Add(this.gridstud);
            this.Controls.Add(this.btndeletecourse);
            this.Controls.Add(this.btnupdatecourse);
            this.Controls.Add(this.btninsertcourse);
            this.Controls.Add(this.txtcpass);
            this.Controls.Add(this.lblcpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdnbe);
            this.Controls.Add(this.rdnte);
            this.Controls.Add(this.rdnse);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttid);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.lblcoursename);
            this.Name = "regstu";
            this.Text = "regstu";
            this.Load += new System.EventHandler(this.regstu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridstud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdnbe;
        private System.Windows.Forms.RadioButton rdnte;
        private System.Windows.Forms.RadioButton rdnse;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttid;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Label lblcpass;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.Button btndeletecourse;
        private System.Windows.Forms.Button btnupdatecourse;
        private System.Windows.Forms.Button btninsertcourse;
        private System.Windows.Forms.DataGridView gridstud;
        private dbttDataSet19 dbttDataSet19;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private dbttDataSet19TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
    }
}