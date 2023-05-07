using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;

namespace DataPassingThroughFun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string data = textBoxDataPassing.Text;

            Form2 PassData = new Form2();
            PassData.GetData(data);
            PassData.ShowDialog();

          //  textBoxPassingData.Text = PassData.TempData;
        }
    }
}
