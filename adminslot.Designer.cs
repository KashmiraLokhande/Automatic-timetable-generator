namespace timetable2
{
    partial class adminslot
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtslotid = new System.Windows.Forms.TextBox();
            this.lblcourseid = new System.Windows.Forms.Label();
            this.btndeletecourse = new System.Windows.Forms.Button();
            this.btnupdatecourse = new System.Windows.Forms.Button();
            this.btninsertcourse = new System.Windows.Forms.Button();
            this.comboteacher = new System.Windows.Forms.ComboBox();
            this.lblteacher = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combotime = new System.Windows.Forms.ComboBox();
            this.comboday = new System.Windows.Forms.ComboBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboclassnum = new System.Windows.Forms.ComboBox();
            this.combocoursename = new System.Windows.Forms.ComboBox();
            this.lblbatch = new System.Windows.Forms.Label();
            this.combobatch = new System.Windows.Forms.ComboBox();
            this.gridslot = new System.Windows.Forms.DataGridView();
            this.slotidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbttDataSet10 = new timetable2.dbttDataSet10();
            this.slotTableAdapter = new timetable2.dbttDataSet10TableAdapters.slotTableAdapter();
            this.rdnbe = new System.Windows.Forms.RadioButton();
            this.rdnte = new System.Windows.Forms.RadioButton();
            this.rdnse = new System.Windows.Forms.RadioButton();
            this.btnshowcourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridslot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.pictureBox1.Image = global::timetable2.Properties.Resources.backicon;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtslotid
            // 
            this.txtslotid.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtslotid.Location = new System.Drawing.Point(302, 22);
            this.txtslotid.Name = "txtslotid";
            this.txtslotid.Size = new System.Drawing.Size(205, 28);
            this.txtslotid.TabIndex = 38;
            // 
            // lblcourseid
            // 
            this.lblcourseid.AutoSize = true;
            this.lblcourseid.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourseid.Location = new System.Drawing.Point(131, 24);
            this.lblcourseid.Name = "lblcourseid";
            this.lblcourseid.Size = new System.Drawing.Size(81, 20);
            this.lblcourseid.TabIndex = 37;
            this.lblcourseid.Text = "SLOT ID";
            // 
            // btndeletecourse
            // 
            this.btndeletecourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeletecourse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndeletecourse.Location = new System.Drawing.Point(686, 391);
            this.btndeletecourse.Name = "btndeletecourse";
            this.btndeletecourse.Size = new System.Drawing.Size(107, 35);
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
            this.btnupdatecourse.Location = new System.Drawing.Point(524, 391);
            this.btnupdatecourse.Name = "btnupdatecourse";
            this.btnupdatecourse.Size = new System.Drawing.Size(110, 35);
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
            this.btninsertcourse.Location = new System.Drawing.Point(344, 391);
            this.btninsertcourse.Name = "btninsertcourse";
            this.btninsertcourse.Size = new System.Drawing.Size(118, 35);
            this.btninsertcourse.TabIndex = 31;
            this.btninsertcourse.Text = "INSERT";
            this.btninsertcourse.UseVisualStyleBackColor = false;
            this.btninsertcourse.Click += new System.EventHandler(this.btninsertcourse_Click);
            // 
            // comboteacher
            // 
            this.comboteacher.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboteacher.FormattingEnabled = true;
            this.comboteacher.Location = new System.Drawing.Point(302, 138);
            this.comboteacher.Name = "comboteacher";
            this.comboteacher.Size = new System.Drawing.Size(205, 28);
            this.comboteacher.TabIndex = 30;
            this.comboteacher.SelectedIndexChanged += new System.EventHandler(this.comboteacher_SelectedIndexChanged);
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.Location = new System.Drawing.Point(131, 141);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(153, 20);
            this.lblteacher.TabIndex = 28;
            this.lblteacher.Text = "TEACHER NAME";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(132, 66);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(57, 20);
            this.lblyear.TabIndex = 27;
            this.lblyear.Text = "YEAR";
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(131, 105);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(140, 20);
            this.lblcoursename.TabIndex = 26;
            this.lblcoursename.Text = "COURSE NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "DAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "TYPE";
            // 
            // combotime
            // 
            this.combotime.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotime.FormattingEnabled = true;
            this.combotime.Items.AddRange(new object[] {
            "10:30-11:30",
            "11:30-12:30",
            "1:30-2:30",
            "2:30-3:30",
            "3:45-4:45",
            "4:45-5:45",
            "10:30-12:30",
            "1:30-3:30",
            "3:45-5:45"});
            this.combotime.Location = new System.Drawing.Point(302, 218);
            this.combotime.Name = "combotime";
            this.combotime.Size = new System.Drawing.Size(205, 28);
            this.combotime.TabIndex = 44;
            // 
            // comboday
            // 
            this.comboday.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboday.FormattingEnabled = true;
            this.comboday.Items.AddRange(new object[] {
            "monday",
            "tuesday",
            "wednesday",
            "thursday",
            "friday",
            "saturday"});
            this.comboday.Location = new System.Drawing.Point(302, 262);
            this.comboday.Name = "comboday";
            this.comboday.Size = new System.Drawing.Size(205, 28);
            this.comboday.TabIndex = 45;
            // 
            // combotype
            // 
            this.combotype.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "lecture",
            "practical"});
            this.combotype.Location = new System.Drawing.Point(302, 309);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(210, 28);
            this.combotype.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "CLASS NUMBER";
            // 
            // comboclassnum
            // 
            this.comboclassnum.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboclassnum.FormattingEnabled = true;
            this.comboclassnum.Location = new System.Drawing.Point(302, 175);
            this.comboclassnum.Name = "comboclassnum";
            this.comboclassnum.Size = new System.Drawing.Size(205, 28);
            this.comboclassnum.TabIndex = 48;
            // 
            // combocoursename
            // 
            this.combocoursename.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocoursename.FormattingEnabled = true;
            this.combocoursename.Location = new System.Drawing.Point(302, 102);
            this.combocoursename.Name = "combocoursename";
            this.combocoursename.Size = new System.Drawing.Size(205, 28);
            this.combocoursename.TabIndex = 49;
            // 
            // lblbatch
            // 
            this.lblbatch.AutoSize = true;
            this.lblbatch.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatch.Location = new System.Drawing.Point(131, 349);
            this.lblbatch.Name = "lblbatch";
            this.lblbatch.Size = new System.Drawing.Size(71, 20);
            this.lblbatch.TabIndex = 50;
            this.lblbatch.Text = "BATCH";
            // 
            // combobatch
            // 
            this.combobatch.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobatch.FormattingEnabled = true;
            this.combobatch.Items.AddRange(new object[] {
            "All Batches",
            "A",
            "B",
            "C",
            "D"});
            this.combobatch.Location = new System.Drawing.Point(302, 349);
            this.combobatch.Name = "combobatch";
            this.combobatch.Size = new System.Drawing.Size(210, 28);
            this.combobatch.TabIndex = 51;
            // 
            // gridslot
            // 
            this.gridslot.AllowUserToAddRows = false;
            this.gridslot.AllowUserToDeleteRows = false;
            this.gridslot.AutoGenerateColumns = false;
            this.gridslot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridslot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridslot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slotidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.tnameDataGridViewTextBoxColumn,
            this.classnumDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.batchDataGridViewTextBoxColumn});
            this.gridslot.DataSource = this.slotBindingSource;
            this.gridslot.Location = new System.Drawing.Point(0, 455);
            this.gridslot.Name = "gridslot";
            this.gridslot.ReadOnly = true;
            this.gridslot.RowTemplate.Height = 24;
            this.gridslot.Size = new System.Drawing.Size(988, 303);
            this.gridslot.TabIndex = 52;
            // 
            // slotidDataGridViewTextBoxColumn
            // 
            this.slotidDataGridViewTextBoxColumn.DataPropertyName = "slotid";
            this.slotidDataGridViewTextBoxColumn.HeaderText = "slotid";
            this.slotidDataGridViewTextBoxColumn.Name = "slotidDataGridViewTextBoxColumn";
            this.slotidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "coursename";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "coursename";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tnameDataGridViewTextBoxColumn
            // 
            this.tnameDataGridViewTextBoxColumn.DataPropertyName = "tname";
            this.tnameDataGridViewTextBoxColumn.HeaderText = "tname";
            this.tnameDataGridViewTextBoxColumn.Name = "tnameDataGridViewTextBoxColumn";
            this.tnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classnumDataGridViewTextBoxColumn
            // 
            this.classnumDataGridViewTextBoxColumn.DataPropertyName = "classnum";
            this.classnumDataGridViewTextBoxColumn.HeaderText = "classnum";
            this.classnumDataGridViewTextBoxColumn.Name = "classnumDataGridViewTextBoxColumn";
            this.classnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "batch";
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            this.batchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slotBindingSource
            // 
            this.slotBindingSource.DataMember = "slot";
            this.slotBindingSource.DataSource = this.dbttDataSet10;
            // 
            // dbttDataSet10
            // 
            this.dbttDataSet10.DataSetName = "dbttDataSet10";
            this.dbttDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // slotTableAdapter
            // 
            this.slotTableAdapter.ClearBeforeFill = true;
            // 
            // rdnbe
            // 
            this.rdnbe.AutoSize = true;
            this.rdnbe.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnbe.Location = new System.Drawing.Point(573, 64);
            this.rdnbe.Name = "rdnbe";
            this.rdnbe.Size = new System.Drawing.Size(61, 24);
            this.rdnbe.TabIndex = 55;
            this.rdnbe.TabStop = true;
            this.rdnbe.Text = "B.E.";
            this.rdnbe.UseVisualStyleBackColor = true;
            this.rdnbe.CheckedChanged += new System.EventHandler(this.rdnbe_CheckedChanged_1);
            // 
            // rdnte
            // 
            this.rdnte.AutoSize = true;
            this.rdnte.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnte.Location = new System.Drawing.Point(428, 64);
            this.rdnte.Name = "rdnte";
            this.rdnte.Size = new System.Drawing.Size(62, 24);
            this.rdnte.TabIndex = 54;
            this.rdnte.TabStop = true;
            this.rdnte.Text = "T.E.";
            this.rdnte.UseVisualStyleBackColor = true;
            this.rdnte.CheckedChanged += new System.EventHandler(this.rdnte_CheckedChanged);
            // 
            // rdnse
            // 
            this.rdnse.AutoSize = true;
            this.rdnse.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnse.Location = new System.Drawing.Point(302, 64);
            this.rdnse.Name = "rdnse";
            this.rdnse.Size = new System.Drawing.Size(59, 24);
            this.rdnse.TabIndex = 53;
            this.rdnse.TabStop = true;
            this.rdnse.Text = "S.E.";
            this.rdnse.UseVisualStyleBackColor = true;
            this.rdnse.CheckedChanged += new System.EventHandler(this.rdnse_CheckedChanged_2);
            // 
            // btnshowcourse
            // 
            this.btnshowcourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnshowcourse.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowcourse.Location = new System.Drawing.Point(676, 60);
            this.btnshowcourse.Name = "btnshowcourse";
            this.btnshowcourse.Size = new System.Drawing.Size(232, 32);
            this.btnshowcourse.TabIndex = 56;
            this.btnshowcourse.Text = "ShowCoursesOfTheseYear";
            this.btnshowcourse.UseVisualStyleBackColor = false;
            this.btnshowcourse.Click += new System.EventHandler(this.btnshowcourse_Click);
            // 
            // adminslot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::timetable2.Properties.Resources.orange_background;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btnshowcourse);
            this.Controls.Add(this.rdnbe);
            this.Controls.Add(this.rdnte);
            this.Controls.Add(this.rdnse);
            this.Controls.Add(this.gridslot);
            this.Controls.Add(this.combobatch);
            this.Controls.Add(this.lblbatch);
            this.Controls.Add(this.combocoursename);
            this.Controls.Add(this.comboclassnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.comboday);
            this.Controls.Add(this.combotime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtslotid);
            this.Controls.Add(this.lblcourseid);
            this.Controls.Add(this.btndeletecourse);
            this.Controls.Add(this.btnupdatecourse);
            this.Controls.Add(this.btninsertcourse);
            this.Controls.Add(this.comboteacher);
            this.Controls.Add(this.lblteacher);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblcoursename);
            this.Name = "adminslot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminslot";
            this.Load += new System.EventHandler(this.adminslot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridslot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbttDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtslotid;
        private System.Windows.Forms.Label lblcourseid;
        private System.Windows.Forms.RadioButton rdnbe;
        private System.Windows.Forms.RadioButton rdnte;
        private System.Windows.Forms.RadioButton rdnse;
        private System.Windows.Forms.Button btndeletecourse;
        private System.Windows.Forms.Button btnupdatecourse;
        private System.Windows.Forms.Button btninsertcourse;
        private System.Windows.Forms.ComboBox comboteacher;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combotime;
        private System.Windows.Forms.ComboBox comboday;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboclassnum;
        private System.Windows.Forms.ComboBox combocoursename;
        private System.Windows.Forms.Label lblbatch;
        private System.Windows.Forms.ComboBox combobatch;
        private System.Windows.Forms.DataGridView gridslot;
        private dbttDataSet10 dbttDataSet10;
        private System.Windows.Forms.BindingSource slotBindingSource;
        private dbttDataSet10TableAdapters.slotTableAdapter slotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnshowcourse;
    }
}