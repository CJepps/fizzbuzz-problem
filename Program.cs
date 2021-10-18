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
            bool prime = true;
            for (int i = 1; i <= 300; i++) // iterates through 1 - 300
            {
                for (int j = 2; j <= 300; j++)// divides a by every number between 2 and 300 
                {
                    if (i != j && i % j == 0) // if a is not the same as b and the remainder when you divide a/b is not zero, the number cannot be prime
                    {
                        prime = false;
                        break;
                    }
                }
                if (!prime)
                {
                    if (i % 3 == 0 && i % 5 == 0)  // IF, after dividing i by 3, the remainder is 0 AND the remainder is 0 after dividing i by 5 PRINT "fizzbuzz" //
                    {
                        Console.WriteLine(i + "-Fizzbuzz /r/n");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine(i + "-Fizz /r/n");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine(i + "-Buzz /r/n");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (prime)
                {
                    Console.Write(i + "-Buzzfizz /r/n "); //prints prime number 

                }
                prime = true;
                
            

            }
           

        }
    }
}
                
               
             
        
    

