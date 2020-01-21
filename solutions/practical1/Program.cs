using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical1
{
    class Program
    {
        static void main(string[] args)
        {
            for(int i=0; i<5; i++) {
                for(int j=0; j<i; j++) 
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}
