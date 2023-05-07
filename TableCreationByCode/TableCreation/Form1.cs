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

namespace TableCreation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeParentTable();
            EmployeInfo();
            foreach (DataGridViewRow Rw in dataGridView2.Rows)
            {

                if (Convert.ToInt32(Rw.Cells[0].Value) == 3)
                {
                    Rw.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            Button btnAdd = new Button();
            btnAdd.Text = "Click Me";
            btnAdd.Width = 150;
            btnAdd.Height = 50;
            btnAdd.Location = new Point(400, 300);
            btnAdd.Click += new System.EventHandler(btnAdd_Click);

            TextBox txtName = new TextBox();
            txtName.Name = "txtfirstName";
            txtName.Width = 200;
            txtName.Location = new Point(312, 280);

            this.Controls.Add(btnAdd);
            this.Controls.Add(txtName);

        
        }
        private void btnAdd_Click(object sender,EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        DataSet dataset;
        private void MakeParentTable()
        {
            //create new table
            DataTable table = new DataTable("ParentTable");
            //declare variables for DataColumn and DataRow object
            DataColumn column;
            DataRow row;

            //create new DataColumn,set DataType
            //Column Name and add to DataTable
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            //add the column to the DataColumnCollection
            table.Columns.Add(column);

            //create second column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentName";
            column.AutoIncrement = false;
            column.Caption = "ParentName";
            column.ReadOnly = true;
            column.Unique = true;
            //add the column tothe table
            table.Columns.Add(column);

            //make the id column primary key column
            DataColumn[] PrimaryKeyColumn = new DataColumn[1];
            PrimaryKeyColumn[0] = table.Columns["id"];
            table.PrimaryKey = PrimaryKeyColumn;

            //instantiate the DataSet variable
            dataset = new DataSet();
            //add the new table into the Dataset
            dataset.Tables.Add(table);

            //create three new DAtaRow objects and add
            //them to the DataTable
            for(int i=0;i<=5;i++)
            {
                row = table.NewRow();
                row["id"] = i;
                row["ParentName"] = "Parentname" + i;
                table.Rows.Add(row);

            }
           dataGridView1.DataSource = table;

        }
        private void EmployeInfo()
        {
            DataTable table = new DataTable("EmployeTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType =  System.Type.GetType("System.String");
            column.ColumnName = "EmpName";
            column.AutoIncrement = false;
            column.Caption = "EmpName";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Designation";
            column.AutoIncrement = false;
            column.Caption = "Designation";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            DataColumn[] PrimaryKeyColumn = new DataColumn[1];
            PrimaryKeyColumn[0] = table.Columns["id"];
            table.PrimaryKey = PrimaryKeyColumn;

            dataset = new DataSet();
            dataset.Tables.Add(table);

            for (int i = 0; i <= 5; i++)
            {
                row = table.NewRow();
                row["id"] = i;
                row["EmpName"]="EmpName"+ i;
                row["Designation"] = "Designation" + i;
                table.Rows.Add(row);

            }
           
            dataGridView2.DataSource = table;

           

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
