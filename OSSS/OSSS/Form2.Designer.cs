namespace WindowsFormsApplication1
{
    partial class OutStudForm
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
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabStudID = new System.Windows.Forms.TabPage();
            this.GPAlabel = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.gviewStudGrades = new System.Windows.Forms.DataGridView();
            this.subjenroll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjgrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSY = new System.Windows.Forms.ComboBox();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblCourseYr = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabSection = new System.Windows.Forms.TabPage();
            this.gViewOutStuds = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbschYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbyrlevel = new System.Windows.Forms.ComboBox();
            this.StudName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tabSearch.SuspendLayout();
            this.tabStudID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewStudGrades)).BeginInit();
            this.tabSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewOutStuds)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.tabStudID);
            this.tabSearch.Controls.Add(this.tabSection);
            this.tabSearch.Location = new System.Drawing.Point(0, -2);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.Size = new System.Drawing.Size(795, 450);
            this.tabSearch.TabIndex = 11;
            // 
            // tabStudID
            // 
            this.tabStudID.Controls.Add(this.btnlogout);
            this.tabStudID.Controls.Add(this.GPAlabel);
            this.tabStudID.Controls.Add(this.lblRemarks);
            this.tabStudID.Controls.Add(this.gviewStudGrades);
            this.tabStudID.Controls.Add(this.label10);
            this.tabStudID.Controls.Add(this.label9);
            this.tabStudID.Controls.Add(this.cmbSY);
            this.tabStudID.Controls.Add(this.cmbSem);
            this.tabStudID.Controls.Add(this.lblGPA);
            this.tabStudID.Controls.Add(this.lblCourseYr);
            this.tabStudID.Controls.Add(this.lblStudName);
            this.tabStudID.Controls.Add(this.btnSearchID);
            this.tabStudID.Controls.Add(this.txtSearchID);
            this.tabStudID.Controls.Add(this.label6);
            this.tabStudID.Location = new System.Drawing.Point(4, 22);
            this.tabStudID.Name = "tabStudID";
            this.tabStudID.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudID.Size = new System.Drawing.Size(787, 424);
            this.tabStudID.TabIndex = 1;
            this.tabStudID.Text = "Search by Student";
            this.tabStudID.UseVisualStyleBackColor = true;
            // 
            // GPAlabel
            // 
            this.GPAlabel.AutoSize = true;
            this.GPAlabel.BackColor = System.Drawing.Color.Transparent;
            this.GPAlabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPAlabel.ForeColor = System.Drawing.Color.Black;
            this.GPAlabel.Location = new System.Drawing.Point(645, 88);
            this.GPAlabel.Name = "GPAlabel";
            this.GPAlabel.Size = new System.Drawing.Size(49, 17);
            this.GPAlabel.TabIndex = 25;
            this.GPAlabel.Text = "GPA:";
            this.GPAlabel.Click += new System.EventHandler(this.GPAlabel_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.Red;
            this.lblRemarks.Location = new System.Drawing.Point(644, 370);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRemarks.Size = new System.Drawing.Size(84, 20);
            this.lblRemarks.TabIndex = 24;
            this.lblRemarks.Text = "Remarks...";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gviewStudGrades
            // 
            this.gviewStudGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gviewStudGrades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gviewStudGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewStudGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjenroll,
            this.subjgrade});
            this.gviewStudGrades.Location = new System.Drawing.Point(35, 125);
            this.gviewStudGrades.Name = "gviewStudGrades";
            this.gviewStudGrades.Size = new System.Drawing.Size(718, 228);
            this.gviewStudGrades.TabIndex = 23;
            // 
            // subjenroll
            // 
            this.subjenroll.HeaderText = "Subjects Enrolled";
            this.subjenroll.Name = "subjenroll";
            // 
            // subjgrade
            // 
            this.subjgrade.HeaderText = "Grades";
            this.subjgrade.Name = "subjgrade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Semester:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "School Year:";
            // 
            // cmbSY
            // 
            this.cmbSY.FormattingEnabled = true;
            this.cmbSY.Items.AddRange(new object[] {
            "2010-2011",
            "2011-2012",
            "2012-2013",
            "2013-2014",
            "2014-2015",
            "2015-2016"});
            this.cmbSY.Location = new System.Drawing.Point(247, 39);
            this.cmbSY.Name = "cmbSY";
            this.cmbSY.Size = new System.Drawing.Size(121, 21);
            this.cmbSY.TabIndex = 18;
            // 
            // cmbSem
            // 
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "Summer"});
            this.cmbSem.Location = new System.Drawing.Point(459, 38);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(121, 21);
            this.cmbSem.TabIndex = 17;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.ForeColor = System.Drawing.Color.Red;
            this.lblGPA.Location = new System.Drawing.Point(695, 84);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(45, 24);
            this.lblGPA.TabIndex = 6;
            this.lblGPA.Text = "GPA";
            this.lblGPA.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCourseYr
            // 
            this.lblCourseYr.AutoSize = true;
            this.lblCourseYr.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseYr.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseYr.ForeColor = System.Drawing.Color.Black;
            this.lblCourseYr.Location = new System.Drawing.Point(326, 88);
            this.lblCourseYr.Name = "lblCourseYr";
            this.lblCourseYr.Size = new System.Drawing.Size(154, 17);
            this.lblCourseYr.TabIndex = 5;
            this.lblCourseYr.Text = "Course and Year";
            this.lblCourseYr.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudName.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudName.ForeColor = System.Drawing.Color.Black;
            this.lblStudName.Location = new System.Drawing.Point(34, 89);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(154, 17);
            this.lblStudName.TabIndex = 4;
            this.lblStudName.Text = "Name of Student";
            // 
            // btnSearchID
            // 
            this.btnSearchID.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchID.Location = new System.Drawing.Point(678, 37);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(44, 40);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(125, 20);
            this.txtSearchID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student ID:";
            // 
            // tabSection
            // 
            this.tabSection.Controls.Add(this.gViewOutStuds);
            this.tabSection.Controls.Add(this.btnSearch);
            this.tabSection.Controls.Add(this.label5);
            this.tabSection.Controls.Add(this.label4);
            this.tabSection.Controls.Add(this.label3);
            this.tabSection.Controls.Add(this.label2);
            this.tabSection.Controls.Add(this.cmbschYear);
            this.tabSection.Controls.Add(this.label1);
            this.tabSection.Controls.Add(this.cmbcourse);
            this.tabSection.Controls.Add(this.cmbSemester);
            this.tabSection.Controls.Add(this.cmbyrlevel);
            this.tabSection.Location = new System.Drawing.Point(4, 22);
            this.tabSection.Name = "tabSection";
            this.tabSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabSection.Size = new System.Drawing.Size(787, 424);
            this.tabSection.TabIndex = 0;
            this.tabSection.Text = "Search by Section";
            this.tabSection.UseVisualStyleBackColor = true;
            // 
            // gViewOutStuds
            // 
            this.gViewOutStuds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gViewOutStuds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewOutStuds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudName,
            this.gpa,
            this.Course,
            this.YearLevel});
            this.gViewOutStuds.Location = new System.Drawing.Point(41, 155);
            this.gViewOutStuds.Name = "gViewOutStuds";
            this.gViewOutStuds.Size = new System.Drawing.Size(705, 245);
            this.gViewOutStuds.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Location = new System.Drawing.Point(627, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "List of Outstanding Students:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Year Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Semester:";
            // 
            // cmbschYear
            // 
            this.cmbschYear.FormattingEnabled = true;
            this.cmbschYear.Items.AddRange(new object[] {
            "2010-2011",
            "2011-2012",
            "2012-2013",
            "2013-2014",
            "2014-2015",
            "2015-2016"});
            this.cmbschYear.Location = new System.Drawing.Point(41, 41);
            this.cmbschYear.Name = "cmbschYear";
            this.cmbschYear.Size = new System.Drawing.Size(121, 21);
            this.cmbschYear.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "School Year:";
            // 
            // cmbcourse
            // 
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.Items.AddRange(new object[] {
            "BEEd",
            "BSEd",
            "ABEng",
            "BSHM",
            "BSIT-DT",
            "BSIT-GT",
            "BSIT-ET",
            "BSIT-CT",
            "BSIT-AT",
            "BSIE",
            "BSICT",
            "BSA",
            "BSF"});
            this.cmbcourse.Location = new System.Drawing.Point(508, 41);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(238, 21);
            this.cmbcourse.TabIndex = 13;
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "Summer"});
            this.cmbSemester.Location = new System.Drawing.Point(186, 41);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 21);
            this.cmbSemester.TabIndex = 12;
            // 
            // cmbyrlevel
            // 
            this.cmbyrlevel.FormattingEnabled = true;
            this.cmbyrlevel.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year",
            "4th year",
            "5th year"});
            this.cmbyrlevel.Location = new System.Drawing.Point(369, 41);
            this.cmbyrlevel.Name = "cmbyrlevel";
            this.cmbyrlevel.Size = new System.Drawing.Size(121, 21);
            this.cmbyrlevel.TabIndex = 11;
            // 
            // StudName
            // 
            this.StudName.HeaderText = "Student Name";
            this.StudName.Name = "StudName";
            // 
            // gpa
            // 
            this.gpa.HeaderText = "GPA";
            this.gpa.Name = "gpa";
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            // 
            // YearLevel
            // 
            this.YearLevel.HeaderText = "Year Level";
            this.YearLevel.Name = "YearLevel";
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(44, 369);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // OutStudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(795, 448);
            this.Controls.Add(this.tabSearch);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "OutStudForm";
            this.Text = "Outstanding Students";
            this.Load += new System.EventHandler(this.OutStudForm_Load);
            this.tabSearch.ResumeLayout(false);
            this.tabStudID.ResumeLayout(false);
            this.tabStudID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewStudGrades)).EndInit();
            this.tabSection.ResumeLayout(false);
            this.tabSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gViewOutStuds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tabStudID;
        private System.Windows.Forms.TabPage tabSection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbschYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbyrlevel;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblCourseYr;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSY;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.DataGridView gViewOutStuds;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.DataGridView gviewStudGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjenroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjgrade;
        private System.Windows.Forms.Label GPAlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearLevel;
        private System.Windows.Forms.Button btnlogout;

    }
}