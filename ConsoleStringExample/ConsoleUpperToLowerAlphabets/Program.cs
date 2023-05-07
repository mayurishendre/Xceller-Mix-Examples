using System;

namespace ConsoleUpperToLowerAlphabets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character...");
           // string ch = Console.ReadLine();
            string ch = string.Empty;

            for(int i=0;i<ch.Length;i++)
            {
                if(ch[i]>='a' && ch[i]<='z')
                {
                    ch += (char)(ch[i] - 32);

                }
                else
                {
                    ch += ch[i];
                }
            }
           // Console.WriteLine("your character is" + ch);
            Console.ReadLine();
            
        }
    }
}
