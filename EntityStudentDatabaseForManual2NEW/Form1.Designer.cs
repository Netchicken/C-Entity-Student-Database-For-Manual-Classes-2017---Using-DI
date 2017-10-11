namespace CollegeDB
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGVStudents = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbxCourses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlAll = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.ToolStripStudents = new System.Windows.Forms.ToolStrip();
            this.tsDeleteStudent = new System.Windows.Forms.ToolStripButton();
            this.tsUpdateStudent = new System.Windows.Forms.ToolStripButton();
            this.tsInsertAdd = new System.Windows.Forms.ToolStripButton();
            this.tsNoMarks = new System.Windows.Forms.ToolStripButton();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.lblWorstBest = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMarksFailed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarksOverFifty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAverageMarks = new System.Windows.Forms.TextBox();
            this.cbxStudents = new System.Windows.Forms.ComboBox();
            this.toolStripMarks = new System.Windows.Forms.ToolStrip();
            this.tsDeleteMarks = new System.Windows.Forms.ToolStripButton();
            this.tsUpdateMarks = new System.Windows.Forms.ToolStripButton();
            this.tsInsertMarks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBestStudent = new System.Windows.Forms.ToolStripButton();
            this.txtmarks4 = new System.Windows.Forms.TextBox();
            this.txtmarks3 = new System.Windows.Forms.TextBox();
            this.txtmarks2 = new System.Windows.Forms.TextBox();
            this.txtmarks1 = new System.Windows.Forms.TextBox();
            this.DGVMarks = new System.Windows.Forms.DataGridView();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.txtHowManyStudents = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DGVCourse = new System.Windows.Forms.DataGridView();
            this.toolStripCourses = new System.Windows.Forms.ToolStrip();
            this.tsDeleteCourse = new System.Windows.Forms.ToolStripButton();
            this.tsUpdateCourse = new System.Windows.Forms.ToolStripButton();
            this.tsInsertCourse = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).BeginInit();
            this.tabControlAll.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.ToolStripStudents.SuspendLayout();
            this.tabMarks.SuspendLayout();
            this.toolStripMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarks)).BeginInit();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCourse)).BeginInit();
            this.toolStripCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVStudents
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVStudents.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DGVStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGVStudents.Location = new System.Drawing.Point(17, 109);
            this.DGVStudents.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.DGVStudents.Name = "DGVStudents";
            this.DGVStudents.RowTemplate.Height = 24;
            this.DGVStudents.Size = new System.Drawing.Size(2726, 844);
            this.DGVStudents.TabIndex = 0;
            this.DGVStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1046, 974);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 974);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 44);
            this.label2.TabIndex = 13;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 966);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(1041, 1027);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(268, 49);
            this.txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(724, 1027);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(268, 49);
            this.txtAddress.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(394, 1027);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 49);
            this.txtName.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 42;
            this.listBox1.Location = new System.Drawing.Point(2591, 151);
            this.listBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(87, 718);
            this.listBox1.TabIndex = 15;
            // 
            // cbxCourses
            // 
            this.cbxCourses.FormattingEnabled = true;
            this.cbxCourses.Location = new System.Drawing.Point(1379, 1027);
            this.cbxCourses.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cbxCourses.Name = "cbxCourses";
            this.cbxCourses.Size = new System.Drawing.Size(327, 50);
            this.cbxCourses.TabIndex = 16;
            this.cbxCourses.SelectedIndexChanged += new System.EventHandler(this.cbxCourses_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1388, 966);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 44);
            this.label4.TabIndex = 17;
            this.label4.Text = "Course";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(73, 1027);
            this.txtID.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(268, 49);
            this.txtID.TabIndex = 18;
            this.txtID.TextChanged += new System.EventHandler(this.AllTextChanged_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 974);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 44);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID";
            // 
            // tabControlAll
            // 
            this.tabControlAll.Controls.Add(this.tabStudents);
            this.tabControlAll.Controls.Add(this.tabMarks);
            this.tabControlAll.Controls.Add(this.tabCourses);
            this.tabControlAll.Location = new System.Drawing.Point(34, 13);
            this.tabControlAll.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabControlAll.Name = "tabControlAll";
            this.tabControlAll.SelectedIndex = 0;
            this.tabControlAll.Size = new System.Drawing.Size(2823, 1268);
            this.tabControlAll.TabIndex = 21;
            // 
            // tabStudents
            // 
            this.tabStudents.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabStudents.Controls.Add(this.ToolStripStudents);
            this.tabStudents.Controls.Add(this.DGVStudents);
            this.tabStudents.Controls.Add(this.cbxCourses);
            this.tabStudents.Controls.Add(this.label5);
            this.tabStudents.Controls.Add(this.txtName);
            this.tabStudents.Controls.Add(this.txtID);
            this.tabStudents.Controls.Add(this.txtAddress);
            this.tabStudents.Controls.Add(this.label4);
            this.tabStudents.Controls.Add(this.txtPhone);
            this.tabStudents.Controls.Add(this.label1);
            this.tabStudents.Controls.Add(this.label2);
            this.tabStudents.Controls.Add(this.label3);
            this.tabStudents.Location = new System.Drawing.Point(14, 66);
            this.tabStudents.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabStudents.Size = new System.Drawing.Size(2795, 1188);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Students";
            // 
            // ToolStripStudents
            // 
            this.ToolStripStudents.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripStudents.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDeleteStudent,
            this.tsUpdateStudent,
            this.tsInsertAdd,
            this.tsNoMarks});
            this.ToolStripStudents.Location = new System.Drawing.Point(7, 8);
            this.ToolStripStudents.Name = "ToolStripStudents";
            this.ToolStripStudents.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripStudents.Size = new System.Drawing.Size(2781, 66);
            this.ToolStripStudents.TabIndex = 21;
            this.ToolStripStudents.Text = "toolStrip2";
            this.ToolStripStudents.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStripStudents_ItemClicked);
            this.ToolStripStudents.Click += new System.EventHandler(this.tsAllStudents_Click);
            // 
            // tsDeleteStudent
            // 
            this.tsDeleteStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDeleteStudent.Enabled = false;
            this.tsDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsDeleteStudent.ForeColor = System.Drawing.Color.Red;
            this.tsDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteStudent.Image")));
            this.tsDeleteStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteStudent.Name = "tsDeleteStudent";
            this.tsDeleteStudent.Size = new System.Drawing.Size(323, 63);
            this.tsDeleteStudent.Text = "Delete Student";
            this.tsDeleteStudent.Click += new System.EventHandler(this.tsDeleteStudent_Click);
            // 
            // tsUpdateStudent
            // 
            this.tsUpdateStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUpdateStudent.Enabled = false;
            this.tsUpdateStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsUpdateStudent.ForeColor = System.Drawing.Color.Green;
            this.tsUpdateStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsUpdateStudent.Image")));
            this.tsUpdateStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdateStudent.Name = "tsUpdateStudent";
            this.tsUpdateStudent.Size = new System.Drawing.Size(339, 63);
            this.tsUpdateStudent.Text = "Update Student";
            this.tsUpdateStudent.Click += new System.EventHandler(this.tsUpdateStudent_Click);
            // 
            // tsInsertAdd
            // 
            this.tsInsertAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsInsertAdd.Enabled = false;
            this.tsInsertAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsInsertAdd.ForeColor = System.Drawing.Color.Blue;
            this.tsInsertAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsInsertAdd.Image")));
            this.tsInsertAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInsertAdd.Name = "tsInsertAdd";
            this.tsInsertAdd.Size = new System.Drawing.Size(243, 63);
            this.tsInsertAdd.Text = "Insert/Add";
            this.tsInsertAdd.Click += new System.EventHandler(this.tsInsertAdd_Click);
            // 
            // tsNoMarks
            // 
            this.tsNoMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNoMarks.Image = ((System.Drawing.Image)(resources.GetObject("tsNoMarks.Image")));
            this.tsNoMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNoMarks.Name = "tsNoMarks";
            this.tsNoMarks.RightToLeftAutoMirrorImage = true;
            this.tsNoMarks.Size = new System.Drawing.Size(208, 63);
            this.tsNoMarks.Text = "No marks";
            this.tsNoMarks.Click += new System.EventHandler(this.tsNoMarks_Click);
            // 
            // tabMarks
            // 
            this.tabMarks.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabMarks.Controls.Add(this.lblWorstBest);
            this.tabMarks.Controls.Add(this.label15);
            this.tabMarks.Controls.Add(this.label14);
            this.tabMarks.Controls.Add(this.label13);
            this.tabMarks.Controls.Add(this.label12);
            this.tabMarks.Controls.Add(this.label11);
            this.tabMarks.Controls.Add(this.label10);
            this.tabMarks.Controls.Add(this.txtMarksFailed);
            this.tabMarks.Controls.Add(this.label9);
            this.tabMarks.Controls.Add(this.txtMarksOverFifty);
            this.tabMarks.Controls.Add(this.label7);
            this.tabMarks.Controls.Add(this.txtAverageMarks);
            this.tabMarks.Controls.Add(this.cbxStudents);
            this.tabMarks.Controls.Add(this.toolStripMarks);
            this.tabMarks.Controls.Add(this.txtmarks4);
            this.tabMarks.Controls.Add(this.txtmarks3);
            this.tabMarks.Controls.Add(this.txtmarks2);
            this.tabMarks.Controls.Add(this.txtmarks1);
            this.tabMarks.Controls.Add(this.DGVMarks);
            this.tabMarks.Location = new System.Drawing.Point(14, 66);
            this.tabMarks.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabMarks.Size = new System.Drawing.Size(2795, 1188);
            this.tabMarks.TabIndex = 1;
            this.tabMarks.Text = "Marks";
            // 
            // lblWorstBest
            // 
            this.lblWorstBest.Location = new System.Drawing.Point(1117, 827);
            this.lblWorstBest.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblWorstBest.Name = "lblWorstBest";
            this.lblWorstBest.Size = new System.Drawing.Size(853, 128);
            this.lblWorstBest.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1628, 659);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(301, 44);
            this.label15.TabIndex = 34;
            this.label15.Text = "Students Names";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1630, 535);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 44);
            this.label14.TabIndex = 33;
            this.label14.Text = "Marks Test 4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1628, 391);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 44);
            this.label13.TabIndex = 32;
            this.label13.Text = "Marks Test 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1630, 244);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 44);
            this.label12.TabIndex = 31;
            this.label12.Text = "Marks Test 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1630, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 44);
            this.label11.TabIndex = 30;
            this.label11.Text = "Marks Test 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(741, 844);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 44);
            this.label10.TabIndex = 29;
            this.label10.Text = "Tests Failed < 50";
            // 
            // txtMarksFailed
            // 
            this.txtMarksFailed.Location = new System.Drawing.Point(743, 899);
            this.txtMarksFailed.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMarksFailed.Name = "txtMarksFailed";
            this.txtMarksFailed.Size = new System.Drawing.Size(268, 49);
            this.txtMarksFailed.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 844);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 44);
            this.label9.TabIndex = 27;
            this.label9.Text = "Marks Over 50";
            // 
            // txtMarksOverFifty
            // 
            this.txtMarksOverFifty.Location = new System.Drawing.Point(391, 899);
            this.txtMarksOverFifty.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMarksOverFifty.Name = "txtMarksOverFifty";
            this.txtMarksOverFifty.Size = new System.Drawing.Size(268, 49);
            this.txtMarksOverFifty.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 844);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 44);
            this.label7.TabIndex = 25;
            this.label7.Text = "Average Marks";
            // 
            // txtAverageMarks
            // 
            this.txtAverageMarks.Location = new System.Drawing.Point(46, 899);
            this.txtAverageMarks.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAverageMarks.Name = "txtAverageMarks";
            this.txtAverageMarks.Size = new System.Drawing.Size(268, 49);
            this.txtAverageMarks.TabIndex = 24;
            // 
            // cbxStudents
            // 
            this.cbxStudents.FormattingEnabled = true;
            this.cbxStudents.Location = new System.Drawing.Point(1635, 712);
            this.cbxStudents.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cbxStudents.Name = "cbxStudents";
            this.cbxStudents.Size = new System.Drawing.Size(327, 50);
            this.cbxStudents.TabIndex = 23;
            // 
            // toolStripMarks
            // 
            this.toolStripMarks.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMarks.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMarks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDeleteMarks,
            this.tsUpdateMarks,
            this.tsInsertMarks,
            this.toolStripSeparator1,
            this.tsBestStudent});
            this.toolStripMarks.Location = new System.Drawing.Point(7, 8);
            this.toolStripMarks.Name = "toolStripMarks";
            this.toolStripMarks.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMarks.Size = new System.Drawing.Size(2781, 64);
            this.toolStripMarks.TabIndex = 22;
            this.toolStripMarks.Text = "toolStrip2";
            // 
            // tsDeleteMarks
            // 
            this.tsDeleteMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDeleteMarks.Enabled = false;
            this.tsDeleteMarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsDeleteMarks.ForeColor = System.Drawing.Color.Red;
            this.tsDeleteMarks.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteMarks.Image")));
            this.tsDeleteMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteMarks.Name = "tsDeleteMarks";
            this.tsDeleteMarks.Size = new System.Drawing.Size(290, 61);
            this.tsDeleteMarks.Text = "Delete Marks";
            // 
            // tsUpdateMarks
            // 
            this.tsUpdateMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUpdateMarks.Enabled = false;
            this.tsUpdateMarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsUpdateMarks.ForeColor = System.Drawing.Color.Green;
            this.tsUpdateMarks.Image = ((System.Drawing.Image)(resources.GetObject("tsUpdateMarks.Image")));
            this.tsUpdateMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdateMarks.Name = "tsUpdateMarks";
            this.tsUpdateMarks.Size = new System.Drawing.Size(306, 61);
            this.tsUpdateMarks.Text = "Update Marks";
            this.tsUpdateMarks.Click += new System.EventHandler(this.tsUpdateMarks_Click);
            // 
            // tsInsertMarks
            // 
            this.tsInsertMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsInsertMarks.Enabled = false;
            this.tsInsertMarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsInsertMarks.ForeColor = System.Drawing.Color.Blue;
            this.tsInsertMarks.Image = ((System.Drawing.Image)(resources.GetObject("tsInsertMarks.Image")));
            this.tsInsertMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInsertMarks.Name = "tsInsertMarks";
            this.tsInsertMarks.Size = new System.Drawing.Size(243, 61);
            this.tsInsertMarks.Text = "Insert/Add";
            this.tsInsertMarks.Click += new System.EventHandler(this.tsInsertMarks_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // tsBestStudent
            // 
            this.tsBestStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBestStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsBestStudent.Image")));
            this.tsBestStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBestStudent.Name = "tsBestStudent";
            this.tsBestStudent.Size = new System.Drawing.Size(412, 61);
            this.tsBestStudent.Text = "Best / Worst Student";
            this.tsBestStudent.Click += new System.EventHandler(this.tsBestStudent_Click);
            // 
            // txtmarks4
            // 
            this.txtmarks4.Location = new System.Drawing.Point(1638, 588);
            this.txtmarks4.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtmarks4.Name = "txtmarks4";
            this.txtmarks4.Size = new System.Drawing.Size(268, 49);
            this.txtmarks4.TabIndex = 4;
            // 
            // txtmarks3
            // 
            this.txtmarks3.Location = new System.Drawing.Point(1635, 443);
            this.txtmarks3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtmarks3.Name = "txtmarks3";
            this.txtmarks3.Size = new System.Drawing.Size(268, 49);
            this.txtmarks3.TabIndex = 3;
            // 
            // txtmarks2
            // 
            this.txtmarks2.Location = new System.Drawing.Point(1635, 296);
            this.txtmarks2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtmarks2.Name = "txtmarks2";
            this.txtmarks2.Size = new System.Drawing.Size(268, 49);
            this.txtmarks2.TabIndex = 2;
            // 
            // txtmarks1
            // 
            this.txtmarks1.Location = new System.Drawing.Point(1635, 155);
            this.txtmarks1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtmarks1.Name = "txtmarks1";
            this.txtmarks1.Size = new System.Drawing.Size(268, 49);
            this.txtmarks1.TabIndex = 1;
            this.txtmarks1.TextChanged += new System.EventHandler(this.AllTextChanged_TextChanged);
            // 
            // DGVMarks
            // 
            this.DGVMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVMarks.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DGVMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMarks.Location = new System.Drawing.Point(17, 109);
            this.DGVMarks.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.DGVMarks.Name = "DGVMarks";
            this.DGVMarks.RowTemplate.Height = 24;
            this.DGVMarks.Size = new System.Drawing.Size(1513, 689);
            this.DGVMarks.TabIndex = 0;
            this.DGVMarks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarks_CellContentClick);
            // 
            // tabCourses
            // 
            this.tabCourses.BackColor = System.Drawing.Color.Lavender;
            this.tabCourses.Controls.Add(this.txtHowManyStudents);
            this.tabCourses.Controls.Add(this.label16);
            this.tabCourses.Controls.Add(this.label6);
            this.tabCourses.Controls.Add(this.textBox1);
            this.tabCourses.Controls.Add(this.textBox2);
            this.tabCourses.Controls.Add(this.label8);
            this.tabCourses.Controls.Add(this.DGVCourse);
            this.tabCourses.Controls.Add(this.toolStripCourses);
            this.tabCourses.Location = new System.Drawing.Point(14, 66);
            this.tabCourses.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Size = new System.Drawing.Size(2795, 1188);
            this.tabCourses.TabIndex = 2;
            this.tabCourses.Text = "Courses";
            // 
            // txtHowManyStudents
            // 
            this.txtHowManyStudents.Location = new System.Drawing.Point(42, 735);
            this.txtHowManyStudents.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtHowManyStudents.Name = "txtHowManyStudents";
            this.txtHowManyStudents.Size = new System.Drawing.Size(268, 49);
            this.txtHowManyStudents.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 674);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(358, 44);
            this.label16.TabIndex = 35;
            this.label16.Text = "How Many Students";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1611, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 44);
            this.label6.TabIndex = 33;
            this.label6.Text = "Course Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1608, 317);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 49);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1608, 191);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 49);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextChanged += new System.EventHandler(this.AllTextChanged_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1611, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 44);
            this.label8.TabIndex = 27;
            this.label8.Text = "Course Time";
            // 
            // DGVCourse
            // 
            this.DGVCourse.BackgroundColor = System.Drawing.Color.Lavender;
            this.DGVCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCourse.Location = new System.Drawing.Point(10, 107);
            this.DGVCourse.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.DGVCourse.Name = "DGVCourse";
            this.DGVCourse.RowTemplate.Height = 24;
            this.DGVCourse.Size = new System.Drawing.Size(1450, 529);
            this.DGVCourse.TabIndex = 23;
            // 
            // toolStripCourses
            // 
            this.toolStripCourses.BackColor = System.Drawing.Color.Transparent;
            this.toolStripCourses.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripCourses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDeleteCourse,
            this.tsUpdateCourse,
            this.tsInsertCourse});
            this.toolStripCourses.Location = new System.Drawing.Point(0, 0);
            this.toolStripCourses.Name = "toolStripCourses";
            this.toolStripCourses.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripCourses.Size = new System.Drawing.Size(2795, 64);
            this.toolStripCourses.TabIndex = 22;
            this.toolStripCourses.Text = "toolStrip2";
            // 
            // tsDeleteCourse
            // 
            this.tsDeleteCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDeleteCourse.Enabled = false;
            this.tsDeleteCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsDeleteCourse.ForeColor = System.Drawing.Color.Red;
            this.tsDeleteCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteCourse.Image")));
            this.tsDeleteCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteCourse.Name = "tsDeleteCourse";
            this.tsDeleteCourse.Size = new System.Drawing.Size(304, 61);
            this.tsDeleteCourse.Text = "Delete Course";
            // 
            // tsUpdateCourse
            // 
            this.tsUpdateCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUpdateCourse.Enabled = false;
            this.tsUpdateCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsUpdateCourse.ForeColor = System.Drawing.Color.Green;
            this.tsUpdateCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsUpdateCourse.Image")));
            this.tsUpdateCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdateCourse.Name = "tsUpdateCourse";
            this.tsUpdateCourse.Size = new System.Drawing.Size(320, 61);
            this.tsUpdateCourse.Text = "Update Course";
            // 
            // tsInsertCourse
            // 
            this.tsInsertCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsInsertCourse.Enabled = false;
            this.tsInsertCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsInsertCourse.ForeColor = System.Drawing.Color.Blue;
            this.tsInsertCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsInsertCourse.Image")));
            this.tsInsertCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInsertCourse.Name = "tsInsertCourse";
            this.tsInsertCourse.Size = new System.Drawing.Size(243, 61);
            this.tsInsertCourse.Text = "Insert/Add";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(2953, 1319);
            this.Controls.Add(this.tabControlAll);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).EndInit();
            this.tabControlAll.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            this.ToolStripStudents.ResumeLayout(false);
            this.ToolStripStudents.PerformLayout();
            this.tabMarks.ResumeLayout(false);
            this.tabMarks.PerformLayout();
            this.toolStripMarks.ResumeLayout(false);
            this.toolStripMarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMarks)).EndInit();
            this.tabCourses.ResumeLayout(false);
            this.tabCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCourse)).EndInit();
            this.toolStripCourses.ResumeLayout(false);
            this.toolStripCourses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbxCourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControlAll;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.TextBox txtmarks4;
        private System.Windows.Forms.TextBox txtmarks3;
        private System.Windows.Forms.TextBox txtmarks2;
        private System.Windows.Forms.TextBox txtmarks1;
        private System.Windows.Forms.DataGridView DGVMarks;
        private System.Windows.Forms.ToolStrip ToolStripStudents;
        private System.Windows.Forms.ToolStripButton tsDeleteStudent;
        private System.Windows.Forms.ToolStripButton tsUpdateStudent;
        private System.Windows.Forms.ToolStripButton tsInsertAdd;
        private System.Windows.Forms.ToolStrip toolStripMarks;
        private System.Windows.Forms.ToolStripButton tsDeleteMarks;
        private System.Windows.Forms.ToolStripButton tsUpdateMarks;
        private System.Windows.Forms.ToolStripButton tsInsertMarks;
        private System.Windows.Forms.DataGridView DGVCourse;
        private System.Windows.Forms.ToolStrip toolStripCourses;
        private System.Windows.Forms.ToolStripButton tsDeleteCourse;
        private System.Windows.Forms.ToolStripButton tsUpdateCourse;
        private System.Windows.Forms.ToolStripButton tsInsertCourse;
        private System.Windows.Forms.ComboBox cbxStudents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMarksFailed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarksOverFifty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAverageMarks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBestStudent;
        private System.Windows.Forms.TextBox txtHowManyStudents;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblWorstBest;
        private System.Windows.Forms.ToolStripButton tsNoMarks;
    }
}

