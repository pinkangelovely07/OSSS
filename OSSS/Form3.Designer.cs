namespace WindowsFormsApplication1
{
    partial class ScholarForm
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
            this.tabSholarship = new System.Windows.Forms.TabControl();
            this.tabSearchSholars = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtSStudID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabAddSholar = new System.Windows.Forms.TabPage();
            this.btnSaveProg = new System.Windows.Forms.Button();
            this.btnAddProg = new System.Windows.Forms.Button();
            this.gviewScholarship = new System.Windows.Forms.DataGridView();
            this.programName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPAReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgpareq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProgName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabSholarship.SuspendLayout();
            this.tabSearchSholars.SuspendLayout();
            this.tabAddSholar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewScholarship)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSholarship
            // 
            this.tabSholarship.Controls.Add(this.tabSearchSholars);
            this.tabSholarship.Controls.Add(this.tabAddSholar);
            this.tabSholarship.Location = new System.Drawing.Point(-1, -1);
            this.tabSholarship.Name = "tabSholarship";
            this.tabSholarship.SelectedIndex = 0;
            this.tabSholarship.Size = new System.Drawing.Size(797, 450);
            this.tabSholarship.TabIndex = 31;
            this.tabSholarship.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabSholarship_Selected);
            // 
            // tabSearchSholars
            // 
            this.tabSearchSholars.Controls.Add(this.button2);
            this.tabSearchSholars.Controls.Add(this.button1);
            this.tabSearchSholars.Controls.Add(this.txtGPA);
            this.tabSearchSholars.Controls.Add(this.label7);
            this.tabSearchSholars.Controls.Add(this.txtYear);
            this.tabSearchSholars.Controls.Add(this.label4);
            this.tabSearchSholars.Controls.Add(this.txtCourse);
            this.tabSearchSholars.Controls.Add(this.label5);
            this.tabSearchSholars.Controls.Add(this.txtLName);
            this.tabSearchSholars.Controls.Add(this.label3);
            this.tabSearchSholars.Controls.Add(this.txtFName);
            this.tabSearchSholars.Controls.Add(this.label2);
            this.tabSearchSholars.Controls.Add(this.Remarks);
            this.tabSearchSholars.Controls.Add(this.label1);
            this.tabSearchSholars.Controls.Add(this.comboBox1);
            this.tabSearchSholars.Controls.Add(this.btnSearchID);
            this.tabSearchSholars.Controls.Add(this.txtSStudID);
            this.tabSearchSholars.Controls.Add(this.label6);
            this.tabSearchSholars.Location = new System.Drawing.Point(4, 22);
            this.tabSearchSholars.Name = "tabSearchSholars";
            this.tabSearchSholars.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchSholars.Size = new System.Drawing.Size(789, 424);
            this.tabSearchSholars.TabIndex = 0;
            this.tabSearchSholars.Text = "Search Scholars";
            this.tabSearchSholars.UseVisualStyleBackColor = true;
            this.tabSearchSholars.Click += new System.EventHandler(this.tabSholars_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(347, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGPA
            // 
            this.txtGPA.Enabled = false;
            this.txtGPA.Location = new System.Drawing.Point(58, 185);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(64, 20);
            this.txtGPA.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "GPA:";
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(542, 117);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(125, 20);
            this.txtYear.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Year Level:";
            // 
            // txtCourse
            // 
            this.txtCourse.Enabled = false;
            this.txtCourse.Location = new System.Drawing.Point(402, 117);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(125, 20);
            this.txtCourse.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Course:";
            // 
            // txtLName
            // 
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(206, 117);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(125, 20);
            this.txtLName.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Last Name:";
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(58, 117);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(125, 20);
            this.txtFName.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "First Name:";
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remarks.ForeColor = System.Drawing.Color.Red;
            this.Remarks.Location = new System.Drawing.Point(562, 318);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(86, 22);
            this.Remarks.TabIndex = 41;
            this.Remarks.Text = "Remarks...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Scholarship Program:";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2010-2011",
            "2011-2012",
            "2012-2013",
            "2013-2014",
            "2014-2015",
            "2015-2016"});
            this.comboBox1.Location = new System.Drawing.Point(402, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // btnSearchID
            // 
            this.btnSearchID.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchID.Location = new System.Drawing.Point(206, 51);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 33;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // txtSStudID
            // 
            this.txtSStudID.Location = new System.Drawing.Point(58, 54);
            this.txtSStudID.Name = "txtSStudID";
            this.txtSStudID.Size = new System.Drawing.Size(125, 20);
            this.txtSStudID.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Student ID:";
            // 
            // tabAddSholar
            // 
            this.tabAddSholar.Controls.Add(this.btnSaveProg);
            this.tabAddSholar.Controls.Add(this.btnAddProg);
            this.tabAddSholar.Controls.Add(this.gviewScholarship);
            this.tabAddSholar.Controls.Add(this.txtgpareq);
            this.tabAddSholar.Controls.Add(this.label10);
            this.tabAddSholar.Controls.Add(this.txtDisc);
            this.tabAddSholar.Controls.Add(this.label9);
            this.tabAddSholar.Controls.Add(this.txtProgName);
            this.tabAddSholar.Controls.Add(this.label8);
            this.tabAddSholar.Location = new System.Drawing.Point(4, 22);
            this.tabAddSholar.Name = "tabAddSholar";
            this.tabAddSholar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddSholar.Size = new System.Drawing.Size(789, 424);
            this.tabAddSholar.TabIndex = 1;
            this.tabAddSholar.Text = "Sholarship Program";
            this.tabAddSholar.UseVisualStyleBackColor = true;
            // 
            // btnSaveProg
            // 
            this.btnSaveProg.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProg.Location = new System.Drawing.Point(284, 71);
            this.btnSaveProg.Name = "btnSaveProg";
            this.btnSaveProg.Size = new System.Drawing.Size(142, 36);
            this.btnSaveProg.TabIndex = 41;
            this.btnSaveProg.Text = "Save Program";
            this.btnSaveProg.UseVisualStyleBackColor = true;
            this.btnSaveProg.Visible = false;
            this.btnSaveProg.Click += new System.EventHandler(this.btnSaveProg_Click);
            // 
            // btnAddProg
            // 
            this.btnAddProg.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProg.Location = new System.Drawing.Point(284, 70);
            this.btnAddProg.Name = "btnAddProg";
            this.btnAddProg.Size = new System.Drawing.Size(142, 36);
            this.btnAddProg.TabIndex = 40;
            this.btnAddProg.Text = "Add Program";
            this.btnAddProg.UseVisualStyleBackColor = true;
            this.btnAddProg.Click += new System.EventHandler(this.btnAddProg_Click);
            // 
            // gviewScholarship
            // 
            this.gviewScholarship.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gviewScholarship.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gviewScholarship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programName,
            this.discAmount,
            this.GPAReq});
            this.gviewScholarship.Location = new System.Drawing.Point(36, 120);
            this.gviewScholarship.Name = "gviewScholarship";
            this.gviewScholarship.ReadOnly = true;
            this.gviewScholarship.Size = new System.Drawing.Size(712, 287);
            this.gviewScholarship.TabIndex = 39;
            // 
            // programName
            // 
            this.programName.DividerWidth = 1;
            this.programName.HeaderText = "Sholarship Programs";
            this.programName.MinimumWidth = 10;
            this.programName.Name = "programName";
            this.programName.ReadOnly = true;
            this.programName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // discAmount
            // 
            this.discAmount.DividerWidth = 1;
            this.discAmount.HeaderText = "Amount Discount";
            this.discAmount.MinimumWidth = 10;
            this.discAmount.Name = "discAmount";
            this.discAmount.ReadOnly = true;
            // 
            // GPAReq
            // 
            this.GPAReq.DividerWidth = 1;
            this.GPAReq.HeaderText = "GPA Requirement";
            this.GPAReq.MinimumWidth = 10;
            this.GPAReq.Name = "GPAReq";
            this.GPAReq.ReadOnly = true;
            // 
            // txtgpareq
            // 
            this.txtgpareq.Location = new System.Drawing.Point(627, 38);
            this.txtgpareq.Name = "txtgpareq";
            this.txtgpareq.Size = new System.Drawing.Size(116, 20);
            this.txtgpareq.TabIndex = 38;
            this.txtgpareq.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(624, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "GPA Requirement:";
            this.label10.Visible = false;
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(475, 38);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(123, 20);
            this.txtDisc.TabIndex = 36;
            this.txtDisc.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Discount:";
            this.label9.Visible = false;
            // 
            // txtProgName
            // 
            this.txtProgName.Location = new System.Drawing.Point(36, 38);
            this.txtProgName.Name = "txtProgName";
            this.txtProgName.Size = new System.Drawing.Size(346, 20);
            this.txtProgName.TabIndex = 34;
            this.txtProgName.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Name of Program:";
            this.label8.Visible = false;
            // 
            // ScholarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(795, 448);
            this.Controls.Add(this.tabSholarship);
            this.Name = "ScholarForm";
            this.Text = "Student Scholarship";
            this.tabSholarship.ResumeLayout(false);
            this.tabSearchSholars.ResumeLayout(false);
            this.tabSearchSholars.PerformLayout();
            this.tabAddSholar.ResumeLayout(false);
            this.tabAddSholar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewScholarship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSholarship;
        private System.Windows.Forms.TabPage tabSearchSholars;
        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtSStudID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabAddSholar;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgpareq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProgName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveProg;
        private System.Windows.Forms.Button btnAddProg;
        private System.Windows.Forms.DataGridViewTextBoxColumn programName;
        private System.Windows.Forms.DataGridViewTextBoxColumn discAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPAReq;
        private System.Windows.Forms.DataGridView gviewScholarship;

    }
}