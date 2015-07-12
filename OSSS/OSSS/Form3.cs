using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ScholarForm : Form
    {
       

        public ScholarForm()
        {
            InitializeComponent();
        }

        private void txtSStudID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabSholars_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProg_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            txtProgName.Visible = true;
            txtDisc.Visible = true;
            txtgpareq.Visible = true;
            btnSaveProg.Visible = true;
            btnAddProg.Visible = false;
        }

        private void btnSaveProg_Click(object sender, EventArgs e)
        {
            DBConnection.Connection();
            string prog = txtProgName.Text;
            double disc = Convert.ToDouble(txtDisc.Text);
            double gpa = Convert.ToDouble(txtgpareq.Text);

            string msg = DBConnection.saveScholarship(prog, disc, gpa);
            MessageBox.Show(msg);

            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            txtProgName.Visible = false;
            txtDisc.Visible = false;
            txtgpareq.Visible = false;
            btnSaveProg.Visible = false;
            btnAddProg.Visible = true;

            txtProgName.Text = "";
            txtDisc.Text = "";
            txtgpareq.Text = "";

            getScholarshipData();

            DBConnection.Terminate();
        }


        private void getScholarshipData()
        {
            DataTable emp = DBConnection.displayScholarships();

            gviewScholarship.Columns[0].HeaderText = "Program Name";
            gviewScholarship.Columns[0].DataPropertyName = "programname";

            gviewScholarship.Columns[1].HeaderText = "Discount";
            gviewScholarship.Columns[1].DataPropertyName = "discount";

            gviewScholarship.Columns[2].HeaderText = "GPA Requirement";
            gviewScholarship.Columns[2].DataPropertyName = "gpareq";


            gviewScholarship.DataSource = emp;
            DBConnection.Terminate();
        }

        private void tabSholarship_Selected(object sender, TabControlEventArgs e)
        {
            getScholarshipData();
            
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
         //   DBConnection.Connection();
            int studID = Convert.ToInt32(txtSStudID.Text);
            DataTable stud = DBConnection.searchStudent(studID);

            txtFName.Text = stud.Rows[0]["studFName"].ToString();
            txtLName.Text = stud.Rows[0]["studLName"].ToString();
            txtCourse.Text = stud.Rows[0]["coursecode"].ToString();
            txtYear.Text = stud.Rows[0]["yearlevel"].ToString();
            cmbProgname.Text = stud.Rows[0]["programname"].ToString();

            btnUpdate.Enabled = true;
           
            DBConnection.Terminate();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            cmbProgname.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}
