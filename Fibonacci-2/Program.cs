using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number for the Fibonacci sequence: ");
            long fibo = long.Parse(Console.ReadLine()), a = 0, b = 1, c = 0;
            bool d = false;
            fibo += 1;


            for (int i = 0; i < fibo; i++)
            {
                if (i < fibo - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);

                }
                if (fibo - 1 == a) d = true;

                c = a + b;
                a = b;
                b = c;


            }
            if (d) Console.WriteLine("\nYour number match with the Fibonacci sequence!");


            Console.ReadKey();
        }
    }
}
