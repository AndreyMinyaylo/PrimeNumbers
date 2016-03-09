using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace SimpleNumbers
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            var firstNumber = -1;
            var secondNumber = -1;
            var n = 0;
            string key;

            do
            {
                Console.WriteLine("Enter the first number: ");
                key = Console.ReadLine();
            } while (!Int32.TryParse(key, out firstNumber) || (firstNumber < 0));

            do
            {
                Console.WriteLine("Enter the last number: ");
                key = Console.ReadLine();
            } while (!Int32.TryParse(key, out secondNumber) || (secondNumber < 0));

            Console.WriteLine("Simple numbers in enter diapazon is:");

            {
                if (firstNumber == 1)
                 {
                firstNumber = firstNumber + 1;
                    for (int i = firstNumber; i <= secondNumber; i++)
                    {
                        int cnt = 0;
                        for (int j = 2; j <= i/2; ++j)
                        {
                            if (i%j == 0)
                                cnt = 1;
                        }
                        if (cnt == 0)
                        {
                            var lenghtI = Convert.ToString(i).Length;
                            var symbolLenght = Convert.ToString(secondNumber).Length;
                            if (lenghtI == symbolLenght)
                            {
                                symbolLenght = 1;
                            }
                            else if (lenghtI < symbolLenght)
                            {
                                symbolLenght = (symbolLenght - lenghtI) + 1;
                            }

                            while (symbolLenght > 0)
                            {
                                Console.Write(' ');
                                symbolLenght--;
                            }

                            Console.Write(i);
                            n++;
                            if (n%5 == 0)
                            {
                                Console.Write('\n');
                            }
                        }
                        

                    }
                }
                
                }
            do
            {
                Console.WriteLine("Enter number and we check number is simple or no:");
                key = Console.ReadLine();
            } while (!Int32.TryParse(key, out firstNumber) || (firstNumber < 0));
            bool is_simple = true;
            for (int i = 2; i < firstNumber/2; i++)
            {

                if (firstNumber%i == 0)
                {
                    is_simple = false;
                    break;


                }
            }
            if (is_simple == true)
            {
                Console.WriteLine("Enter number " + firstNumber + " is simple number!");
            }
            else
            {
                Console.Write("Enter number " + firstNumber + " is not simple number!");
            }
            Console.ReadKey();
        }
        }
            }
        

