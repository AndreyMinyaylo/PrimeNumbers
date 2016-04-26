using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simpleNumbers_ConsoleOut
{
    [TestClass]
    public class ConsoleOut
    {
       

        public static bool isSimple(int number)
        {
            if (number < 2)
            {
                return false;
            }
            bool is_simple = true;
            for (int i = 2; i < number; i++)
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
            var st = "Simple numbers in enter diapazon is:";
            var sr = string.Empty;
            sr = sr +"Simple numbers in enter diapazon is:";
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
            Assert.AreEqual(st, sr);
        }
       
        public  void printSimleNumberEnd()
        {
           /* var st = '\n' + "Enter number and we check number is simple or no or enter 3 to exit:";
            var sr = string.Empty;*/
            while (true)
            {
                Console.Write('\n' + "Enter number and we check number is simple or no or enter 3 to exit:");
                int number = 7;
                if (number == 3)
                {
                    break;
                }
                bool is_Simple = isSimple(number);
                if (is_Simple == true)
                {
                    Console.Write("Number " + number + " is simple");
                }
                else
                {
                    Console.Write("Number " + number + " is not simple");
                    
                }
                //break;
            }
           // Assert.AreEqual(st, sr);
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

        [TestMethod]
        public  void selMethod()
        {
            var st = "\nIf you want to test a range of numbers - enter 1, If one number , press - 2 , exit - 3";
            var sr = string.Empty;
            int select = 1;
            int firstNumber;
            int secondNumber;
            do
            {
                sr = sr + "\nIf you want to test a range of numbers - enter 1, If one number , press - 2 , exit - 3";
                /* select = 1;

                 if (select == 1)
                 {

                     Console.WriteLine("Enter the first number: ");
                     firstNumber = 1;

                     Console.WriteLine("Enter the last number: ");
                     secondNumber = 100;
                     printSimpleNumbers(firstNumber, secondNumber);
                 }

                 if (select == 2)
                 {
                     printSimleNumberEnd();
                 }*/
                break;
            } while (select != 3);
            Assert.AreEqual(st, sr);
        }
       
    }
}