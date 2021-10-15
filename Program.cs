using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 301; i++) {   // for loop iterates from 1 - 100 //
                if (i % 3 == 0 && i % 5 ==0)  // IF, after dividing i by 3, the remainder is 0 AND the remainder is 0 after dividing i by 5 PRINT "fizzbuzz" //
                {
                    Console.WriteLine(i + "-Fizzbuzz");
                } 
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + "-Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "-Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
