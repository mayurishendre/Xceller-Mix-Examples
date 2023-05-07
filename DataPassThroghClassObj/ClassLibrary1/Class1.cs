using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DataHandler         //step1... create class for DataHander
    {
       
            public string data = "";        //string data me textbox passing data k under ka store rhega   ex. "Hello"
            public void GetData(string textdata)           //Getdata function bnaya
            {
                data = textdata;          
            }

        //public string dattaa = "";      ...asssighnment 2 reverse
        //public void TakeData(string  textdataa)
        //{
        //    dattaa = textdataa;
        //}

    }
}
