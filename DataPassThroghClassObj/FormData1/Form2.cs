using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;    //step3...add reference

namespace FormData1
{
    public partial class Form2 : Form
    {
        public DataColumnChangeEventHandler HandleData = null;
        public Form2(DataHandler objHandler)
        {

            InitializeComponent();
          //  textBox2.Text = objHandler.data;

            textBoxCatchingData.Text = objHandler.data;

        }

        


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //private void btnSave_Click(object sender, EventArgs e)             ...Assighment 2/Reverse
        //{
        //    DataHandler HandleData = new DataHandler();    //create obj of DataHandler of classlibray
        //    HandleData.GetData(textBox2.Text);         //passing data in obj of classlibrary in existing function Getdata

        //    Form2 PassData = new Form2(HandleData);         //create obj for form2 and pass Obj of DataHandler classlibray
        //    PassData.ShowDialog();

        //    textBox2.Text = HandleData.data;

        //}
    }
    
}
