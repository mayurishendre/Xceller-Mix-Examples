using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class CustomerBaseClass
    {
                public string CustomerName { get; set; }
                public string phoneNumber { get; set; }
                public Decimal BillAmount{ get; set; }
                public DateTime BillDate{ get; set; }
                public string Address { get; set; }

        public virtual void Validate()                  //for the validation step3  ,override this method into derive class (lead,customer)
        {
            throw new Exception("Not implemented...");
        }

    }

    //step1
    //In the below code the bproblem is Duplication Of Properties.
    //Ann should be in common class
    // inorder to reduce the code move all the properties to common class say CustomerBase(above)

    public class Customer : CustomerBaseClass
    {
        //public string CustomerName { get; set; }
        //public double phoneNumber { get; set; }
        //public Decimal BillAmount { get; set; }
        //public DateTime BillDate { get; set; }
        //public string Address { get; set; }

        public override void Validate()         //override step4 //from base to derive
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Name is Compulsory");
            }
            if (phoneNumber.Length == 0)
            {
                throw new Exception("PhoneNumber is Compulsory");
            }
            if (BillAmount == 0)
            {
                throw new Exception("BillAmount is Compulsory");
            }
            if (BillDate >= DateTime.Now)
            {
                throw new Exception(" invalid Date");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is Compulsory");
            }
        }
    }
    //step2
    public class lead : CustomerBaseClass
    {
        //public string CustomerName { get; set; }
        //public string phoneNumber { get; set; }

        public override void Validate()
        {
            if(CustomerName.Length==0)
            {
                throw new Exception("Name is Compulsory");

            }
            if(phoneNumber.Length==0)
            {
                throw new Exception("phone number is compulsory");

            }
        }
    }

}
