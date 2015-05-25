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

    public partial class osssForm : Form
    {

        Form oForm = new OutStudForm();
        Form sForm = new ScholarForm();


        public osssForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPass.Text;

            string permission = DBConnection.checkLogin(username, password);

            if (permission == "O")
                    oForm.Show();
            else if (permission == "S")
                    sForm.Show();
            else
                MessageBox.Show("Username and Password did not match!");


            DBConnection.Terminate();
        }
    }
}
