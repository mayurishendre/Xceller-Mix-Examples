using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;    //step2.....add reference of classlibrary

namespace FormData1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // textBox1.Text = objectHandler ....assighment 2 reverse 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Assighnment1
            //    DataHandler HandleData = new DataHandler();    //create obj of DataHandler of classlibray
            //    HandleData.GetData(textBoxPassingData.Text);         //passing data in obj of classlibrary in existing function Getdata

            //    Form2 PassData = new Form2(HandleData);         //create obj for form2 and pass Obj of DataHandler classlibray
            //    PassData.ShowDialog();

            //textBoxPassingData.Text = HandleData.data;

            Data = textBoxPassingData.Text;

            Form2 PassData = new Form2();
            PassData.GetData(Data);
            PassData.ShowDialog();

            textBoxPassingData.Text = PassData.TempData;


        }
      

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
