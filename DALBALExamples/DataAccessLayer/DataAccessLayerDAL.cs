using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using System.Data;

namespace DataAccessLayer
{
    public class DAL
    {


        SqlCommand cmd = new SqlCommand();
        public static string constr = "Data Source=.;Initial Catalog=StudentinformationDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);


        public SqlConnection Connect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }              
            con.Open();
            return con;

        }
        public SqlCommand getCommand()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            return con;
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Close();
        }
        public System.Data.ConnectionState GetConnectionState()
        {
            GetConnectionState();
            return con.State;
        }
    }   
}
