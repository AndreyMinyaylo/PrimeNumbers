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
        public static bool isSimple(int number)
        {
            if (number < 2)
            {
                return false;
            }
            bool is_simple = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    is_simple = false;
                    break;
                }
            }
            return is_simple;
        }



        public static void printToMatrix(int i, int secondNumber)
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
        }

        public static void printSimpleNumbers(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Simple numbers in enter diapazon is:");
            var n = 0;
            {
                if (firstNumber == 1)
                {
                    firstNumber = firstNumber + 1;
                }
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    bool is_simple = isSimple(i);
                    if (is_simple == true)
                    {
                        printToMatrix(i, secondNumber);
                        n++;
                        if (n % 10 == 0)
                        {
                            Console.Write('\n');
                        }
                    }
                }
            }
        }

        public static void printSimleNumberEnd()
        {
            string newString = "\n",
                checkString = "Enter number and we check number is simple or no or enter 3 to exit:";

            while (true)
            {
                Console.WriteLine(String.Format("{0}{1}",newString,checkString));
                int number = consoleRead();
                if (number == 3)
                {
                    break;
                }
                bool is_Simple = isSimple(number);
                if (is_Simple == true)
                {
                    Console.Write(string.Format("Number {0} is simple", number));
                }
                else
                {
                    Console.Write(string.Format("Number {0} is not simple",number));
                }
            }
        }

        public static int consoleRead()
        {
            string key;
            int number;
            do
            {
                key = Console.ReadLine();
            } while (!Int32.TryParse(key, out number) || (number < 0));
            return number;
        }


        public static void selMethod()
        {
            int select;
            int firstNumber;
            int secondNumber;
            string change_1 = "If you want to test a range of numbers - enter 1, ",
                    change_2 = "If one number , press - 2, ",
                    change_3 = "exit - 3",
                    newString = "\n";
            do
            {
                

                Console.WriteLine(String.Format("{0}{1}{2}{3}", newString, change_1, change_2, change_3));
                select = consoleRead();

                if (select == 1)
                {

                    Console.WriteLine("Enter the first number: ");
                    firstNumber = consoleRead();

                    Console.WriteLine("Enter the last number: ");
                    secondNumber = consoleRead();
                    printSimpleNumbers(firstNumber, secondNumber);
                }

                if (select == 2)
                {
                    printSimleNumberEnd();
                }

            } while (select != 3);
        }

        public static
        void Main(string[] args)
        {
            selMethod();
            Console.ReadKey();
        }
    }
}




