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
    public partial class OutStudForm : Form
    {
       

        public OutStudForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void OutStudForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            gviewStudGrades.Rows.Clear();
            DBConnection.Connection();
            int sID = Convert.ToInt32(txtSearchID.Text);
            string sy = cmbSY.Text;
            string sem = cmbSem.Text;
            Object fname, lname, mname, coursecode, yrlevel;

            if (sem == "1st Semester")
                {
                    sem = "1";
                }
            else if (sem == "2nd Semester")
                {
                    sem = "2";
                }
            else if (sem == "Summer")
                {
                    sem = "3";
                }

            DataTable stud = DBConnection.generateStud(sID,sy,sem);
            if (stud.Rows.Count > 0)
            {
                fname = stud.Rows[0]["studFname"];
                lname = stud.Rows[0]["studLName"];
                mname = stud.Rows[0]["studMName"];
                coursecode = stud.Rows[0]["coursecode"];
                yrlevel = stud.Rows[0]["yearlevel"];

                lblStudName.Text = fname.ToString() + " " + mname.ToString() + " " + lname.ToString();
                lblCourseYr.Text = coursecode.ToString() + " " + yrlevel.ToString();

                double sum = 0, GPA;
                int totalunits = 0;

                for (int i = 0; i < stud.Rows.Count; i++)
                {
                    gviewStudGrades.Rows.Add(stud.Rows[i]["subjdesc"], stud.Rows[i]["grade"]);
                    sum = sum + (Convert.ToDouble(stud.Rows[i]["grade"]) * Convert.ToDouble(stud.Rows[i]["units"]));
                    totalunits = totalunits + Convert.ToInt32(stud.Rows[i]["units"]);
                }
                GPA = sum / totalunits;

                lblGPA.Text = GPA.ToString();

                if (GPA <= 1.75)
                    lblRemarks.Text = "Dean's Lister!";
                else
                    lblRemarks.Text = "Strive Harder!";


                //DataTable dt = new DataTable();
                //dt.Clear();
                //dt.Columns.Add("idstudents");
                //dt.Columns.Add("semester");
                //dt.Columns.Add("schyear");
                //dt.Columns.Add("gpa");
                //DataRow dr = dt.NewRow();
                //dr["idstudents"] = sID;
                //dr["semester"] = sem;
                //dr["schyear"] = sy;
                //dr["gpa"] = GPA;

                //DBConnection.saveGPA(sID, sem, sy, GPA);     
            }

            else
            {
                DBConnection.Terminate();
               
            }

        }

        private void GPAlabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   
            gViewOutStuds.Rows.Clear();
            DBConnection.Connection();
            string sy = cmbschYear.Text;
            string sem = cmbSemester.Text;
            int yrlevel = 0;
            string course = cmbcourse.Text;

            if (sem == "1st Semester")
            {
                sem = "1";
            }
            else if (sem == "2nd Semester")
            {
                sem = "2";
            }
            else if (sem == "Summer")
            {
                sem = "3";
            }


            if (cmbyrlevel.Text  == "1st year")
            {
                yrlevel = 1;
            }
            else if (cmbyrlevel.Text == "2nd year")
            {
                yrlevel = 2;
            }
            else if (cmbyrlevel.Text == "3rd year")
            {
                yrlevel = 3;
            }
            else if (cmbyrlevel.Text == "4th year")
            {
                yrlevel = 4;
            }
            else if (cmbyrlevel.Text == "5th year")
            {
                yrlevel = 5;
            }

            DataTable sec = DBConnection.generateStudbySection(sy, sem, yrlevel, course);
            for (int i=0; i< sec.Rows.Count; i++)
            {
                string fname = sec.Rows[i]["studFname"].ToString();
                string lname = sec.Rows[i]["studLName"].ToString();

                gViewOutStuds.Rows.Add(fname + " " + lname, sec.Rows[i]["gpa"], sec.Rows[i]["coursecode"], sec.Rows[i]["yearlevel"]);
            }


        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form os = new osssForm();
            this.Close();
          //  serverlogin login = new serverlogin();
            os.Show();
        }



    }
}
