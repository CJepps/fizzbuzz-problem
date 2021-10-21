using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_problem
{
    class Program
    {
        static public void Main(string[] args)
        {
            string FirstWord = "fizz";          // insert desired words here
            string SecondWord = "buzz";
            int NumberRange = 300;              // insert desired number range here
            
            for (int i = 1; i <= NumberRange; i++)
            {
                string result = "";

                if (i % 3 == 0)
                {
                    result += FirstWord;
                }
                if (i % 5 == 0)
                {
                    result += SecondWord;
                }
                else if (PrimeMethod(i))
                {
                    result += SecondWord + FirstWord;

                }
                Console.WriteLine(i + " " + result);
            }




            bool PrimeMethod(int i)
            {
                bool prime = true;


                for (int j = 2; j <= i; j++)// divides i by every number between 2 and 300 
                {
                    if (i != j && i % j == 0) // if i is not the same as j and the remainder when you divide i/j is not zero, the number cannot be prime
                    {
                        prime = false;
                        break;
                    }

                }

                return prime;
            }
        }
    }
}