using System;
using System.Data.SqlClient;

namespace Employee_Management {

    class Login {

        public bool LoginInfo(string username, string pwd) {
            SqlConnection con = new SqlConnection(@"server=LAPTOP-7FIGL6S6;database=employeeDB;integrated security = true");
            SqlCommand cmd_login = new SqlCommand("select count(*) from login where username=@username and password=@pwd", con);
            cmd_login.Parameters.AddWithValue("@username",username);
            cmd_login.Parameters.AddWithValue("@pwd",pwd);
        
        try {
            con.Open();
            int login_count = (int) cmd_login.ExecuteScalar();
            if(login_count > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch(Exception es) {
            throw new Exception(es.Message);
        }
        finally {
            con.Close();
        }
    }
    }
}