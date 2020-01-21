using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical1
{
    class Program
    {
        static void pattern1()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void pattern2()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = i; j >= 0; j--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            pattern1();
            Console.WriteLine();
            pattern2();
            Console.ReadLine();
        }
        
    }
}
