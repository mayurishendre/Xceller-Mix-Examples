using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.Data.SqlClient;   //step1
using BussinessAccessLayerBAL;
using DataAccessLayerDAL;



namespace InstituteRegistration
{
    public partial class frmInstituteRegistration : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        //step2
        DAL objD = new DAL();
        BAL objB = new BAL();
        public frmInstituteRegistration()
        {
            InitializeComponent();
            con = objD.GetConnection();
            cmd = objD.getCommand();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            object[] colName = new object[6];
            object[] colData = new object[6];

            colName[0] = "InstituteNames";
            colName[1] = "Address";
            colName[2] = "City";
            colName[3] = "CenterNo";
            colName[4] = "OwnerName";
            colName[5] = "ContactNo";
            

            colData[0] = txtIName.Text.ToUpper();
            colData[1] = txtAddress.Text;
            colData[2] = txtCity.Text;
            colData[3] = txtCtNo.Text.ToUpper();
            colData[4] = txtOwnerName.Text;
            colData[5] = txtContactNo.Text;

            int Result = objB.SaveData("tblInstitutReg", colName, colData, 6);
            {
                try
                {

                    if (Result == 1)
                    {
                        MessageBox.Show("Record Saved...");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //for Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            object[] colName = new object[6];
            object[] colData = new object[6];

            colName[0] = "InstituteNames";          
            colName[1] = "Address";                 
            colName[2] = "City";                    
            colName[3] = "CenterNo";                
            colName[4] = "OwnerName";              
            colName[5] = "ContactNo";               

            colData[0] = txtIName.Text;
            colData[1] = txtAddress.Text;
            colData[2] = txtCity.Text;
            colData[3] = txtCtNo.Text;
            colData[4] = txtOwnerName.Text;
            colData[5] = txtContactNo.Text;


            int Result = objB.UpdateData("tblInstitutReg", colName, colData, 6);
            {
                if (Result == 1)
                {
                    MessageBox.Show("Record Updated...");
                }
            }
        }
        //for Delete
        int ID;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
           // cmd.CommandText = "delete from tblInstitutReg where IID =" + ID;

            DialogResult dr = MessageBox.Show("Are you sure you want to Delete this Record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {

                int Result = objB.DeleteData("tblInstitutReg", "IID", ID);
                {

                    if (Result == 1)
                    {
                        MessageBox.Show("Record Deleted...");
                        
                    }
                }
            }

        }

        //private void btnAddNames_Click(object sender, EventArgs e)
        //{
        //    cmbNames.Items.Add(txtBoxIName.Text);
        //    txtBoxIName.Clear();
        //    txtBoxIName.Focus();
        //}

        //private void btnAddAddress_Click(object sender, EventArgs e)
        //{
        //    cmbAddress.Items.Add(txtBoxAddress.Text);
        //    txtBoxAddress.Clear();
        //    txtBoxAddress.Focus();
        //}

        private void txtboxContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if (k >= 48 && k <= 57 || k == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

      
        private void txtboxOwnerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if ((k >= 65 && k <= 90) || (k >= 97 && k <= 122) || (k == 8) || (k == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxIName_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if ((k >= 65 && k <= 90) || (k >= 97 && k <= 122) || (k == 8) || (k == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar;
            if ((k >= 65 && k <= 90) || (k >= 97 && k <= 122) || (k == 8) || (k == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;                                          //code for storing records in datagrid view
            ID = Convert.ToInt32( dgvInstitution.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIName.Text = dgvInstitution.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddress.Text = dgvInstitution.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCity.Text = dgvInstitution.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCtNo.Text = dgvInstitution.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtOwnerName.Text = dgvInstitution.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtContactNo.Text = dgvInstitution.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string Query = "select * from tblInstitutReg  where InstituteNames like'" + txtSearch.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblInstitutReg");
            dgvInstitution.DataSource = ds.Tables[0];
        }

       
        private void frmInstituteRegistration_Load(object sender, EventArgs e)
        {
                                                                              // code for display datagridview on form and run
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblInstitutReg", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblInstitutReg");
            dgvInstitution.DataSource = ds.Tables[0];
        }

        private void groupBoxIR_Enter(object sender, EventArgs e)
        {

        }

        //private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string InstituteNames = cmbNames.SelectedItem.ToString();
        //    switch(InstituteNames)
        //    {
        //        case "PBCOE":
        //            cmbNames.Items.Clear();
        //            cmbNames.Text = "---Select---";
        //            cmbAddress.Items.Add("Umred Road,Nagpur");
        //            break;

        //        case "YCCE":
        //            cmbNames.Items.Clear();
        //            cmbNames.Text = "---Select---";
        //            cmbAddress.Items.Add("Hingna Road,Nagpur");
        //            break;

        //        case "RCOE":
        //            cmbNames.Items.Clear();
        //            cmbNames.Text = "---Select---";
        //            cmbAddress.Items.Add("Amravati,Nagpur");
        //            break;

        //        case "KDK":
        //            cmbNames.Items.Clear();
        //            cmbNames.Text = "---Select---";
        //            cmbAddress.Items.Add("Jagnade Square,Nagpur");
        //            break;

        //    }
        //}

        //private void cmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmbAddress.Text = "";
        //    string Address = cmbAddress.SelectedItem.ToString();
        //    switch(Address)
        //    {
        //    case ""
        //    }
        //}
    }
}
