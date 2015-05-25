using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public class DBConnection
    {
        private static string SQL;
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        private static MySqlDataAdapter da;
        private static DataSet ds;
       // private static MySqlDataReader rdr;

        static DBConnection()
        {
            string strConn = Connection();
        }

        public static string Connection()
        {
            try
            {
                string mysqldb = "SERVER=localhost; DATABASE=osss; UID=root; PASSWORD=pass;";
                conn = new MySqlConnection(mysqldb);
                conn.Open();

            }
            catch (MySqlException e)
            {
                return e.Message;
            }
            
            return conn.State.ToString();

        }

        //login validity check with permission to Outstanding or Scholarship Form
        public static string checkLogin(string username, string password)
        {
            string permission;
            SQL = "SELECT permission from users WHERE username='" + username + "' AND password='" + password + "';";
            cmd = new MySqlCommand(SQL, conn);

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                permission = result.ToString();
                return permission;
            }

            return "N";
        }

        //Searching Scholars through Student ID
        public static DataTable searchStudent(int studID)
        {
            int ID = studID;
            SQL = "SELECT * FROM students as s, scholarships as sc WHERE s.idstudents =" + ID + " AND s.idscholarships = sc.idscholarships;";
            cmd = new MySqlCommand(SQL, conn);

            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];

        }

        //to display list of scholarship programs from database
        public static DataTable displayScholarships()
        {
            SQL = "SELECT programname, discount, gpareq from scholarships WHERE idscholarships <> 1000 ORDER BY programname ASC;";
            cmd = new MySqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }

        //Adding new scholarship program
        public static string saveScholarship(string progname, double discount, double gpareq)
        {
            string pname = progname;
            double disc = discount;
            double gpa = gpareq;
            SQL = "INSERT INTO scholarships (programname, discount, gpareq) VALUES ('" +pname+ "'," +disc+ "," +gpa+ ");";
            cmd = new MySqlCommand(SQL, conn);
          //  cmd.CommandType = CommandType.Text;
          //  da = new MySqlDataAdapter(cmd);

            //rdr = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
            
            return "New Sholarship Program Added Successfully!";
        }

        
        public static void Terminate()
        {
            conn.Close();
        }
    }
}
