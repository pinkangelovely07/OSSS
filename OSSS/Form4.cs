using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class loginForm : Form
    {
        osssForm osssForm = new osssForm();
        OutStudForm oForm = new OutStudForm();
        ScholarForm sForm = new ScholarForm();
        DBConnection dbconn = new DBConnection();

        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtUserName.Text;
            //string password = txtPass.Text;
            //string permission = osssForm.getValue();

           
            //if (DBConnection.checkLogin(username, password, permission))
            //    if (permission=="O")
            //        oForm.Show();
            //    else
            //        sForm.Show();
            //else
            //    MessageBox.Show("Username and Password did not match!");
            
            
            //this.Close();
        
        }

        //private void LoginCheck()
        //{
        //    string username = txtUserName.Text;
        //    string password = txtPass.Text;

        //    if (DBConnection.checkLogin(username,password)
           
        //}
    }
}
