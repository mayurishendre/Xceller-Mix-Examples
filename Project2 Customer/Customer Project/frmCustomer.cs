using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory;

//if alredy class created on window form then only dont need to reference
using MiddleLayer;     //step5      //create derive class's object by reference of middle layer

namespace Customer_Project
{
    public partial class frmCustomer : Form
    {

        public frmCustomer()
        {
            InitializeComponent();
        }

        //  private Customer cust=null;             ..... derive class obj
        //private lead lead = null;
        //insted of creating objects of base class then only create base class object

        private CustomerBaseClass objBase = null;      //... object of baseclass

        private void SetCustomer()
        {
            objBase.CustomerName = txtboxCustomeName.Text;
            objBase.phoneNumber = txtboxPhNo.Text;
            objBase.Address = txtboxAddress.Text;
            objBase.BillAmount = Convert.ToDecimal(txtboxBillAmount);
            objBase.BillDate = Convert.ToDateTime(txtboxBillDate);

        }

        private void cmbCustomeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomeType.Text == "Customer")
            {
                objBase = new Customer();
                // Cust = new Customer();
            }
            else
            {
                objBase = new lead();
            }
            objBase = Factoryyy.Create(cmbCustomeType.Text);

        }
        
        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                objBase.Validate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ////if(cmbCustomerType.text=="Customer)
            //{
            //    //cust.validate();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("hello");
        }
    }
    
}
