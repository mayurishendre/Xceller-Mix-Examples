using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerDAL
{
    public class DAL
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        
        string M_str = "Data Source =.; Initial Catalog = InstituteRegistrationDB; Integrated Security = True";
        public SqlConnection GetConnection()
        {
            try
            {
                con.Dispose();
                con.ConnectionString = M_str;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
            }
            catch(Exception ex)
            {

            }
            return con;
        }
        public SqlCommand getCommand()
        {
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
            }
            catch(Exception ex)
            {

            }
            return cmd;
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Close();
            }
        }

        public System.Data.ConnectionState GetConnectionState()
        {
            GetConnection();
            return con.State;
        }

    }
}
