using System;

namespace ConsoleApp4IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            else if(a +b < 10)
            {
                Console.WriteLine("The answer is not greater than 10.");
            }
            else if(a + b == 0)
            {
                Console.WriteLine("the answer is equal to zero");
            }
            Console.WriteLine(a + b > 10 ? "es mayor a 10" : "no es mayor a 10");
        }
    }
}
