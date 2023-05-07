using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;      //step1

namespace Console_SqlTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
 
           // Console.WriteLine(sname + "\n" + M1 + "\n" + M2 + "\n" + M3 + "\n" + Qualification + "\n" + city + "\n" + DOB + "\n" + Gender);
           // Console.ReadLine();
        }
        public static void Menu()
        {
           
            Console.WriteLine("...Menu...");        
            Console.WriteLine("enter 1 for insert");
            Console.WriteLine("enter 2 for read");
            Console.WriteLine("enter 3 for update");
            Console.WriteLine("enter 4 for delete");
            Console.WriteLine("enter your choice");

            selectOption();
        }
        public static void selectOption()
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(" your data is inserted successfully");
                    InsertRecord();
                 //   selectOption();
                    Repeate();
                    break;
                case 2:
                    Console.WriteLine("your data is read successfully ");
                    ReadAllRecord();
                   // selectOption();
                    Repeate();
                    break;
                case 3:
                    Console.WriteLine("your data is updated successfully");
                    UpdateRecord();
                   // selectOption();
                    Repeate();
                    break;
                case 4:
                    Console.WriteLine("your data is deleted successfully");
                    DeleteRecord();
                    Repeate();
                    
                    break;
                default:
                    Console.WriteLine("not possible");
                    break;
            }
        }
        public static void InsertRecord()
        {
            string sname;
            int M1;
            int M2;
            int M3;
            string Qualification;
            string city;
            string DOB;
            string Gender;

            Console.WriteLine("enter the information of students...");
            sname = Console.ReadLine();
            Console.WriteLine("enter M1...");
            M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter M2...");
            M2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter M3...");
            M3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Qualification...");
            Qualification = Console.ReadLine();
            Console.WriteLine("enter city...");
            city = Console.ReadLine();
            Console.WriteLine("enter DOB...");
            DOB = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter Gender...");
            Gender = Console.ReadLine();

            //step3
            SqlParameter p1 = new SqlParameter("@Sname", SqlDbType.VarChar);
            //step 4
            p1.Value = sname.ToUpper();                //create parameter
            SqlParameter p2 = new SqlParameter("@M1", SqlDbType.Int);
            p2.Value = M1;
            SqlParameter p3 = new SqlParameter("@M2", SqlDbType.Int);
            p3.Value = M2;
            SqlParameter p4 = new SqlParameter("@M3", SqlDbType.Int);
            p4.Value = M3;
            SqlParameter p5 = new SqlParameter("@DOB", SqlDbType.VarChar);
            p5.Value = DOB.ToUpper();
            SqlParameter p6 = new SqlParameter("@Gender", SqlDbType.VarChar);
            p6.Value = Gender.ToUpper();
            SqlParameter p7 = new SqlParameter("@Qualification", SqlDbType.VarChar);
            p7.Value = Qualification;
            SqlParameter p8 = new SqlParameter("@City", SqlDbType.VarChar);
            p8.Value = city.ToUpper();

            //step5
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentinformationDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            //step6
            cmd.Connection = con;

            //step7
            cmd.CommandText = "insert into tblStudentInfo(Sname,M1,M2,M3,DOB,Gender,Qualification,City)values(@Sname,@M1,@M2,@M3,@DOB,@Gender,@Qualification,@City)";

            //step8
            con.Open();

            //step9
            cmd.ExecuteNonQuery();

            //step10
            con.Close();

            Console.WriteLine("Record Inserted successfully");
            Console.ReadLine();

        }
        public static void ReadAllRecord()
        {
            SqlConnection can = new SqlConnection("Data Source=.;Initial Catalog=StudentinformationDB;Integrated Security=True");
            SqlCommand cmdo = new SqlCommand();
            SqlDataReader dr;

            cmdo.Connection = can;

            cmdo.CommandText = "Select * from tblStudentInfo";

            can.Open();
            dr = cmdo.ExecuteReader();

            while (dr.Read())
            {
                Console.Write(dr[1].ToString()+" ");             //type1 (output showing)
              //  Console.WriteLine(dr["Sname"].ToString());     //type2 (outpt showing)
                Console.Write(dr[2].ToString()+" ");
              //  Console.WriteLine(dr["M1"].ToString());
                Console.Write(dr[3].ToString()+" ");
                Console.Write(dr[4].ToString()+" ");
                Console.Write(dr[5].ToString()+" ");
                Console.Write(dr[6].ToString()+" ");
                Console.Write(dr[7].ToString()+" ");
                Console.WriteLine(dr[8].ToString()+" ");

              
            }
            can.Close();
          //  dr.Close();
        }
        public static void UpdateRecord()
        {
            string Sname;
            int M1;
            int M2;
            int M3;
            string Qualification;
            string city;
            string DOB;
            string Gender;
            int Id;

            Console.WriteLine("enter your id..");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Name...");
            Sname = Console.ReadLine();
            Console.WriteLine("enter M1...");
            M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter M2...");
            M2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter M3...");
            M3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Qualification...");
            Qualification = Console.ReadLine();
            Console.WriteLine("enter city...");
            city = Console.ReadLine();
            Console.WriteLine("enter DOB...");
            DOB = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter Gender...");
            Gender = Console.ReadLine();

            //step2
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentinformationDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();      //create obj

            //step3
            SqlParameter p1 = new SqlParameter("@Sname", SqlDbType.VarChar);
            p1.Value = Sname.ToUpper();
            SqlParameter p2 = new SqlParameter("@M1", SqlDbType.Int);
            p2.Value = M1;
            SqlParameter p3 = new SqlParameter("@M2", SqlDbType.Int);
            p3.Value = M2;
            SqlParameter p4 = new SqlParameter("@M3", SqlDbType.Int);
            p4.Value = M3;
            SqlParameter p5 = new SqlParameter("@DOB", SqlDbType.Int);
            p5.Value = DOB;
            SqlParameter p6 = new SqlParameter("@Gender", SqlDbType.VarChar);
            p6.Value = Gender.ToUpper();
            SqlParameter p7 = new SqlParameter("@Qualification", SqlDbType.VarChar);
            p7.Value = Qualification.ToUpper();
            SqlParameter p8 = new SqlParameter("@City", SqlDbType.VarChar);
            p8.Value = city.ToUpper();

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);

            cmd.Connection =con;

            cmd.CommandText = "Upadte tblStudentInfobset col1=@Sname,col2=@M1,col3=M2,col4=@M3,col5=@DOB,col6=@Gender,col7=@Qualification,col8=@City where Rno="+Id;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        public static void DeleteRecord()
        {
            int ID;
            Console.WriteLine("enter the id");
            ID = Convert.ToInt32(Console.ReadLine());
             
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentinformationDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Delete from tblStudentInfo where Rno=" + ID;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        public static void Repeate()
        {
            Char ch;
           
            Console.WriteLine("Do you want to continue...? (Y/N)");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch=='y' || ch=='Y')
            {
                Console.WriteLine("to be continued...");
                Menu();
               
            }
            else
            {
                Console.WriteLine("thank you.");
            }
        }
    }
}
