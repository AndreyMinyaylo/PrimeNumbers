using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
             Console.WriteLine("Enter first number:");
             var firstNumber = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter second number:");
             var secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == 1)
            {
                firstNumber = firstNumber  + 1;
            }

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                
                int cnt = 0;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                        cnt = 1;
                }
                if (cnt == 0)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}