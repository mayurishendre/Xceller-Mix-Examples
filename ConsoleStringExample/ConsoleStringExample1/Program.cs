using System;

namespace ConsoleStringExample1
{
    class Program
    {
        enum Days { sun,mon,tue,wed,thu,fri,sat};
        static void Main(string[] args)
        {
            string Fname, Lname;
            Fname = "Vilas";
            Lname = "Dongre";
            Console.WriteLine("Hello " + Fname + " " + Lname);   //Hello Vilas Dongre

            //single characters
            char[] ch = { 'h', 'e', 'l', 'l', 'o' };
            string letters = new string(ch);
            Console.WriteLine("character {0}",letters);

            //string array
            string[] StringArray = { "Good", "Morning", "all", "Of", "you" };
            string msg = String.Join("  ", StringArray);
            Console.WriteLine("String Array={0}", msg);
            int idx = msg.IndexOf("M", 0);
            Console.WriteLine("characters 'M' found at " + idx + "position");

            int ans = string.Compare(Fname, Lname);
            if(ans!=0)
            {
                Console.WriteLine("both the string are different");
            }
            else
            {
                Console.WriteLine("both the string are same");
            }
            int WeekdayStart = (int)Days.mon;
            int weekdayEnd = (int)Days.fri;
            Console.WriteLine("Monday :{0}", WeekdayStart);
            Console.WriteLine("Friday :{0}", weekdayEnd);

            Console.ReadLine();
;
        }
       
    }
}
