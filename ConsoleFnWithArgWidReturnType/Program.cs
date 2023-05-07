using System;

namespace ConsoleFnWithArgWidReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            input();
            Console.ReadLine();
        }
        public static void input()
        {
            int num1 = 4;
            int num2 = 5;
            int add = calculate(num1, num2);
            Console.WriteLine("addition" + add);
            Console.WriteLine("sum=" + calculate(num1, 45));
        }
        //function with argument with return type
        public static int calculate(int n1,int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
    }
}
