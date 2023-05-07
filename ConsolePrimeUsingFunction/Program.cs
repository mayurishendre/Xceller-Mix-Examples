using System;

namespace ConsolePrimeUsingFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers..");
            int number = Convert.ToInt32(Console.ReadLine());
            prime(number);
            Console.ReadLine();
        }
        public static void prime(int num)
        {
             int count;
             for(count=2;count < num;count++)
             {
               if(num % count == 0)
               {
                  Console.WriteLine("number is not prime");
                  break;
               }
             }
             if(count == num)
             {
                  Console.WriteLine("number is prime");
             }
             Console.ReadLine();

       }

    }
}
