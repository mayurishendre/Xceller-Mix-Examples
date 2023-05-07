using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace BussinessAccessLayer
{
    public class StudentRegistration
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlTransaction trs;
        DAL dm = new DAL();

        //variables
        string singleqt="";

        public StudentRegistration()
        {
            con = dm.Connect();
            cmd = dm.getCommand();
        }
        
        public void SaveData(string StudentDetail ,object[] colName,object[] colData,int counter)
        {
            if(con.State==ConnectionState.Closed)
            {
                con = dm.Connect();
                cmd = dm.getCommand();
            }
            string sql = "insert into [" + StudentDetail + "](";
            string MValues = "";

            for(int i=0;i<=counter;i++)
            {
                sql = sql + Convert.ToString(colName[i]) + ",";
            }
            int lstIndex = sql.LastIndexOf(",");
            sql = sql.Remove(lstIndex, 1);

            sql = sql = ")values(";

            for(int j=0;j<=counter;j++)
            {
                if(IsNumeric(colData[i])==true)
                {
                    MValues = MValues + colData[j] + ",";
                }
                else
                {
                    MValues = MValues + singleqt + colData[j] + singleqt + ",";
                }
            }
            lstIndex = MValues.LastIndexOf(",");
        }
    }
}
