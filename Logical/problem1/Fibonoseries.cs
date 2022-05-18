using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    internal class Fibonacci
    {

        public void FibonacciSeries()
        {
            Console.WriteLine("Enter how many fibonacci number do you want");
            int Lenght = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            if (Lenght < 1)
            {
                Console.Write("The number should be a positive integer");
            }
            else
            {
                if (Lenght == 1)
                {
                    Console.Write("The series is:{0}", a);
                }
                else if (Lenght == 2)
                {
                    Console.Write("The series is: {0} {1}", a, b);
                }
                else
                {
                    Console.Write("The series is: {0} {1}", a, b);
                    for (int i = 2; i < Lenght; i++)
                    {
                        c = a + b;
                        Console.Write(" {0}", c);
                        a = b;
                        b = c;
                    }
                }
            }
        }
    }
}
