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
            void main()
             {
                for (int i = 1; i <= 300; i++)
                {
                    string result = "";
                    if (primeMethod())
                    {
                        result += "BuzzFizz";
                        break;
                    }

                    if (i % 3 == 0)
                    {
                        result += "fizz";
                    }
                    if (i % 5 == 0)
                    {
                        result += "Buzz";
                    }
                    Console.WriteLine(i + " " + result);
                }
             }

             bool primeMethod()
            {
                bool prime = true;
                for (int i = 1; i <= 300; i++) // iterates through 1 - 300
                
                    for (int j = 2; j <= 300; j++)// divides i by every number between 2 and 300 
                    {
                        if (i != j && i % j == 0) // if i is not the same as j and the remainder when you divide i/j is not zero, the number cannot be prime
                        {
                            prime = false;
                            break;
                        }
                        
                    }
                
                return prime;
            }

            
                
              
            main();
            primeMethod();

           


        }
    }
}
                
               
             
        
    

