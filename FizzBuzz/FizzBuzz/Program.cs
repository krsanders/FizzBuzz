using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.ReadKey();       
        }
        public static string FizzBuzz(int number)
        {
        // if divisible by 3 == fizz
        // if divisible by 5 == buzz
        // if divisible by both == fizzbuzz

            if (number % 3 == 0 && number % 5 == 0)
            {
                //IS divisible by BOTH 3 and 5
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                //IS divisible by 3
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                //IS divisible by 5
                return "Buzz";
            }
            return number.ToString();           
        }
    }
}
