using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CountryStateBySqlJoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CountryStateDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCountry();
            LoadState();
        }
        private void LoadCountry()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblCountry",con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblCountry");
            dgvCountry.DataSource = ds.Tables[0];
        }
        private void LoadState()
        {
            SqlDataAdapter SDA = new SqlDataAdapter("select * from tblState",con);
            DataSet DS = new DataSet();
            SDA.Fill(DS, "tblState");
            dgvState.DataSource = DS.Tables[0];
        }

        private void btnInnerJoin_Click(object sender, EventArgs e)
        {
            //
            SqlDataAdapter Sda = new SqlDataAdapter("select * from tblCountry inner join tblState on tblCountry.CountryCode=tblState.CountryCode",con);
            DataSet Ds = new DataSet();
            DataTable dt = new DataTable("tblResult");
            Sda.Fill(dt);

            dgvResult.DataSource = dt;
        }

        private void btnLeftJoin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblCountry left join tblState on tblCountry.CountryCode=tblState.CountryCode", con);
            DataSet Ds = new DataSet();
            DataTable dt = new DataTable("tblResult");
            sda.Fill(dt);
            dgvResult.DataSource = dt;
        }

        private void btnRightJoin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblCountry Right join tblState on tblCountry.CountryCode=tblState.CountryCode", con);
            DataSet Ds = new DataSet();
            DataTable dt = new DataTable("tblResult");
            sda.Fill(dt);
            dgvResult.DataSource = dt;
        }

       

        private void btnFullOuterJoin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblCountry full outer join tblState on tblCountry.CountryCode=tblState.CountryCode", con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("tblResult");
            sda.Fill(dt);
            dgvResult.DataSource = dt;
        }
    }
}
