namespace timetable2
{
    partial class adminclassroom
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
            this.txtclassnum = new System.Windows.Forms.TextBox();
            this.lblclassnum = new System.Windows.Forms.Label();
            this.btndeletecourse = new System.Windows.Forms.Button();
            this.btnupdatecourse = new System.Windows.Forms.Button();
            this.btninsertcourse = new System.Windows.Forms.Button();
            this.txtnumofseat = new System.Windows.Forms.TextBox();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdnse = new System.Windows.Forms.RadioButton();
            this.rdnte = new System.Windows.Forms.RadioButton();
            this.rdnbe = new System.Windows.Forms.RadioButton();
            this.dbttDataSet16 = new timetable2.dbttDataSet16();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classroomTableAdapter = new timetable2.dbttDataSet16TableAdapters.classroomTableAdapter();
            this.classnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofseatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
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
            this.classnumDataGridViewTextBoxColumn,
            this.numofseatDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gridcourse.DataSource = this.classroomBindingSource;
            this.gridcourse.Location = new System.Drawing.Point(-6, 362);
            this.gridcourse.Name = "gridcourse";
            this.gridcourse.RowTemplate.Height = 24;
            this.gridcourse.Size = new System.Drawing.Size(995, 396);
            this.gridcourse.TabIndex = 50;
            this.gridcourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcourse_CellContentClick);
            // 
            // txtclassnum
            // 
            this.txtclassnum.Location = new System.Drawing.Point(371, 44);
            this.txtclassnum.Name = "txtclassnum";
            this.txtclassnum.Size = new System.Drawing.Size(186, 22);
            this.txtclassnum.TabIndex = 49;
            // 
            // lblclassnum
            // 
            this.lblclassnum.AutoSize = true;
            this.lblclassnum.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclassnum.Location = new System.Drawing.Point(169, 46);
            this.lblclassnum.Name = "lblclassnum";
            this.lblclassnum.Size = new System.Drawing.Size(146, 20);
            this.lblclassnum.TabIndex = 48;
            this.lblclassnum.Text = "CLASS NUMBER";
            // 
            // btndeletecourse
            // 
            this.btndeletecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndeletecourse.Location = new System.Drawing.Point(714, 300);
            this.btndeletecourse.Name = "btndeletecourse";
            this.btndeletecourse.Size = new System.Drawing.Size(114, 35);
            this.btndeletecourse.TabIndex = 47;
            this.btndeletecourse.Text = "DELETE";
            this.btndeletecourse.UseVisualStyleBackColor = false;
            this.btndeletecourse.Click += new System.EventHandler(this.btndeletecourse_Click);
            // 
            // btnupdatecourse
            // 
            this.btnupdatecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdatecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdatecourse.Location = new System.Drawing.Point(543, 300);
            this.btnupdatecourse.Name = "btnupdatecourse";
            this.btnupdatecourse.Size = new System.Drawing.Size(123, 35);
            this.btnupdatecourse.TabIndex = 46;
            this.btnupdatecourse.Text = "UPDATE";
            this.btnupdatecourse.UseVisualStyleBackColor = false;
            this.btnupdatecourse.Click += new System.EventHandler(this.btnupdatecourse_Click);
            // 
            // btninsertcourse
            // 
            this.btninsertcourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsertcourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertcourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninsertcourse.Location = new System.Drawing.Point(371, 300);
            this.btninsertcourse.Name = "btninsertcourse";
            this.btninsertcourse.Size = new System.Drawing.Size(148, 35);
            this.btninsertcourse.TabIndex = 45;
            this.btninsertcourse.Text = "INSERT";
            this.btninsertcourse.UseVisualStyleBackColor = false;
            this.btninsertcourse.Click += new System.EventHandler(this.btninsertcourse_Click);
            // 
            // txtnumofseat
            // 
            this.txtnumofseat.Location = new System.Drawing.Point(371, 96);
            this.txtnumofseat.Name = "txtnumofseat";
            this.txtnumofseat.Size = new System.Drawing.Size(186, 22);
            this.txtnumofseat.TabIndex = 43;
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(169, 98);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(177, 20);
            this.lblcoursename.TabIndex = 41;
            this.lblcoursename.Text = "NUMBER OF SEATS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.pictureBox1.Image = global::timetable2.Properties.Resources.backicon;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(173, 151);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(55, 20);
            this.lbltype.TabIndex = 52;
            this.lbltype.Text = "TYPE";
            // 
            // combotype
            // 
            this.combotype.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "lecture",
            "practical"});
            this.combotype.Location = new System.Drawing.Point(371, 151);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(186, 25);
            this.combotype.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "YEAR";
            // 
            // rdnse
            // 
            this.rdnse.AutoSize = true;
            this.rdnse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnse.Location = new System.Drawing.Point(371, 210);
            this.rdnse.Name = "rdnse";
            this.rdnse.Size = new System.Drawing.Size(63, 24);
            this.rdnse.TabIndex = 55;
            this.rdnse.TabStop = true;
            this.rdnse.Text = "S.E.";
            this.rdnse.UseVisualStyleBackColor = true;
            this.rdnse.CheckedChanged += new System.EventHandler(this.rdnse_CheckedChanged);
            // 
            // rdnte
            // 
            this.rdnte.AutoSize = true;
            this.rdnte.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnte.Location = new System.Drawing.Point(511, 210);
            this.rdnte.Name = "rdnte";
            this.rdnte.Size = new System.Drawing.Size(65, 24);
            this.rdnte.TabIndex = 56;
            this.rdnte.TabStop = true;
            this.rdnte.Text = "T.E.";
            this.rdnte.UseVisualStyleBackColor = true;
            this.rdnte.CheckedChanged += new System.EventHandler(this.rdnte_CheckedChanged);
            // 
            // rdnbe
            // 
            this.rdnbe.AutoSize = true;
            this.rdnbe.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnbe.Location = new System.Drawing.Point(659, 210);
            this.rdnbe.Name = "rdnbe";
            this.rdnbe.Size = new System.Drawing.Size(64, 24);
            this.rdnbe.TabIndex = 57;
            this.rdnbe.TabStop = true;
            this.rdnbe.Text = "B.E.";
            this.rdnbe.UseVisualStyleBackColor = true;
            this.rdnbe.CheckedChanged += new System.EventHandler(this.rdnbe_CheckedChanged);
            // 
            // dbttDataSet16
            // 
            this.dbttDataSet16.DataSetName = "dbttDataSet16";
            this.dbttDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataMember = "classroom";
            this.classroomBindingSource.DataSource = this.dbttDataSet16;
            // 
            // classroomTableAdapter
            // 
            this.classroomTableAdapter.ClearBeforeFill = true;
            // 
            // classnumDataGridViewTextBoxColumn
            // 
            this.classnumDataGridViewTextBoxColumn.DataPropertyName = "classnum";
            this.classnumDataGridViewTextBoxColumn.HeaderText = "classnum";
            this.classnumDataGridViewTextBoxColumn.Name = "classnumDataGridViewTextBoxColumn";
            // 
            // numofseatDataGridViewTextBoxColumn
            // 
            this.numofseatDataGridViewTextBoxColumn.DataPropertyName = "numofseat";
            this.numofseatDataGridViewTextBoxColumn.HeaderText = "numofseat";
            this.numofseatDataGridViewTextBoxColumn.Name = "numofseatDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // adminclassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.rdnbe);
            this.Controls.Add(this.rdnte);
            this.Controls.Add(this.rdnse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridcourse);
            this.Controls.Add(this.txtclassnum);
            this.Controls.Add(this.lblclassnum);
            this.Controls.Add(this.btndeletecourse);
            this.Controls.Add(this.btnupdatecourse);
            this.Controls.Add(this.btninsertcourse);
            this.Controls.Add(this.txtnumofseat);
            this.Controls.Add(this.lblcoursename);
            this.Name = "adminclassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminclassroom";
            this.Load += new System.EventHandler(this.adminclassroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridcourse;
        private System.Windows.Forms.TextBox txtclassnum;
        private System.Windows.Forms.Label lblclassnum;
        private System.Windows.Forms.Button btndeletecourse;
        private System.Windows.Forms.Button btnupdatecourse;
        private System.Windows.Forms.Button btninsertcourse;
        private System.Windows.Forms.TextBox txtnumofseat;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdnse;
        private System.Windows.Forms.RadioButton rdnte;
        private System.Windows.Forms.RadioButton rdnbe;
        private dbttDataSet16 dbttDataSet16;
        private System.Windows.Forms.BindingSource classroomBindingSource;
        private dbttDataSet16TableAdapters.classroomTableAdapter classroomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofseatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}