using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DataAccessLayerDAL;
using System.Windows.Forms;

namespace BussinessAccessLayerBAL
{
    public class BAL
    {
        SqlConnection con1;
        SqlCommand cmd1;
       
        SqlTransaction trs1;
        DAL dm = new DAL();

        string Singleqt = "'";
        //string Doubleqt = "\''";

        public BAL()
        {
            dm.CloseConnection();
            con1 = dm.GetConnection();
            cmd1 = dm.getCommand();

        }

        public int SaveData(string tblInstitutReg, object[] feilds,object[] values,int counter)
        {
            if(con1.State==ConnectionState.Closed)
            {
                con1 = dm.GetConnection();
                cmd1 = dm.getCommand();
            }
            string sql = "insert into[" + tblInstitutReg + "](";
            
            string MValues = "";

            for(int i=0;i<counter;i++)
            {
                sql = sql + Convert.ToString(feilds[i]) + ",";
            }
            int lstIndex = sql.LastIndexOf(",");
            sql = sql.Remove(lstIndex, 1);
            sql = sql + ")values(";

            for(int j=0;j<counter;j++)
            {
                if((IsNumeric(values[j])==true))
                {
                    MValues = MValues + values[j] + ",";
                }
                else
                {
                    MValues = MValues + Singleqt + values[j] + Singleqt +",";
                }
            }
            lstIndex = MValues.LastIndexOf(",");
            MValues = MValues.Remove(lstIndex, 1);
            MValues = MValues + ")";
            trs1 = con1.BeginTransaction();
            cmd1.Transaction = trs1;
            cmd1.CommandText = sql + MValues;

            if(cmd1.ExecuteNonQuery() !=0)
            {
                trs1.Commit();
                trs1.Dispose();
                dm.CloseConnection();
                return 1;
            }
            else
            {
                trs1.Rollback();
                trs1.Dispose();
                dm.CloseConnection();
                return 0;
            }
            
        }
        public Boolean IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = double.TryParse(Convert.ToString(Expression),
                System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;

        }

        public int UpdateData (string tblInstitutReg, object[] colName,object[] colData,int counter)
        {
            dm.GetConnection();
           // string Singleqt = "''";
            string sql = " UPDATE " + tblInstitutReg + " SET ";
            //sql=update tblInstituteReg set InstituteName=AkashDhopte, Address=Varora where IID=5;
            //for (int i = 0; i < counter; i++)
            //{
            //    sql = sql + Convert.ToString(colName[i]) + ",";
            //}
           // int lstIndex = sql.LastIndexOf(",");
            //sql = sql.Remove(lstIndex, 1);
            //sql = sql + ")colData(";

            for (int i = 0; i< counter; i++)
            {
                if ((IsNumeric(colData[i]) == true))
                {
                   sql=sql+Convert.ToString(colName[i] + "='" + colData[i]) +"',";
                }
                else
                {
                   sql=sql+Convert.ToString(colName[i]) + "='" + colData[i] + "',";
                }
            }
            int index = sql.LastIndexOf(",");
            sql=sql.Remove(index, 1);
             sql = sql + " WHERE " + colName[0] + "='" + colData[0] + "';";
           // sql = "update tblInstitutReg set InstituteNames ='nikitDhopte', Address = 'Varora' where IID = 5";
            trs1 = con1.BeginTransaction();
            cmd1.Transaction = trs1;
            cmd1.CommandText = sql;

            if (cmd1.ExecuteNonQuery() != 0)
            {
                trs1.Commit();
                trs1.Dispose();
                dm.CloseConnection();
                return 1;
            }
            else
            {
                trs1.Rollback();
                trs1.Dispose();
                dm.CloseConnection();
                return 0;
            }



        }
        public int DeleteData(string TableName,string criteriacolName,int criteriacolData)
        {
            if (con1.State == ConnectionState.Closed)
            {
                con1 = dm.GetConnection();
                cmd1 = dm.getCommand();
            
            }
          // string x = dgvInstitution.Rows[e.RowIndex].Cells[0].Value.ToString();
            string sql = "DELETE from " + TableName + " WHERE " + criteriacolName + " = " + criteriacolData;
            cmd1.Connection = con1;
           // sql = "delete from tblInstitutReg where IID=4";
            trs1 = con1.BeginTransaction();
            cmd1.Transaction = trs1;
            cmd1.CommandText = sql;

             if (cmd1.ExecuteNonQuery() != 0)
            {
                trs1.Commit();
                trs1.Dispose();
                dm.CloseConnection();
                return 1;
            }
            else
            {
                trs1.Rollback();
                trs1.Dispose();
                dm.CloseConnection();
                return 0;
            }
        }

        public void FillGrid(DataGridView dgv, string tblInstitutReg, string DisplayMember, string ValueMember, Boolean orderby, string orderfield)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable(tblInstitutReg);
            SqlDataAdapter ad = default(SqlDataAdapter);

            if (orderby == true)
            {
                ad = new SqlDataAdapter("select" + ValueMember + "," + DisplayMember + "from[" + tblInstitutReg + "]ORDERBY" + orderfield, con1);

            }
            else
            {
                ad = new SqlDataAdapter("select" + ValueMember + "," + DisplayMember + "from[" + tblInstitutReg + "]ORDERBY", con1);
            }
            ad.Fill(ds, tblInstitutReg);
            dgv.DataSource = ds.Tables[tblInstitutReg];
            dgv.DataMember = ds.Tables[tblInstitutReg].ToString();

        }
        

    }
        

}
