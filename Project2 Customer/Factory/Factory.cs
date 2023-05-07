using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiddleLayer;

namespace Factory
{
    //this class is responsible for the creation of object
    public  class Factoryyy             //classname
    {
        //creating the method for the creation of objects  depending upon the type
        public static CustomerBaseClass Create(string TypeCustomer)
        {
            //when this method return the strong type of object thennit returns asaparent base class
            //so instead of void it shouild be customerBase
            if(TypeCustomer=="Customer")
            {
                return new Customer();
                //cust=new Customer;

            }
            else
            {
                return new lead();
                //cust=new Lead();

            }
            //now we need to remove this IF condition from this class
            //instead of that use Generics.
            return cust[TypeCustomer];
        }
        private static Dictionary<string, CustomerBaseClass> cust = new Dictionary<string, CustomerBaseClass>();

        static Factoryyy()                   //classnameoffactory
        {
            cust.Add("Customer", new Customer());
            cust.Add("Lead", new lead());
        }
    }
}
