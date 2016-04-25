using System;
using System.Security.AccessControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_matrix_simpleNumbers
{
    [TestClass]
    public class Test_matrix
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
                if (number%i == 0)
                {
                    is_simple = false;
                    break;
                }
            }
            return is_simple;
        }
        
        public static string printToMatrix(int i, int secondNumber, string sr)
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
                sr = sr + (' ');
                symbolLenght--;
            }
            
            sr = sr + (i);
            Console.Write(i);
            return sr;
        }

        public static string printSimpleNumbers(int firstNumber, int secondNumber)
        {
             var sr = string.Empty;
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
                    sr =  printToMatrix(i, secondNumber, sr);
                        n++;
                        if (n % 5 == 0)
                        {
                            sr = sr + ('\n');
                        }
                    }
                }
            }
            return sr;
        }

        public static int consoleRead(string secondNumber)
        {
            string key;
            int number;
            do
            {
                key = secondNumber;
            } while (!Int32.TryParse(key, out number) || (number < 0));
            return number;
        }

       [TestMethod]
        public  void selMethod()
        {
            var st ="   2   3   5   7  11\n" +
                    "  13  17  19  23  29\n" +
                    "  31  37  41  43  47\n" +
                    "  53  59  61  67  71\n" +
                    "  73  79  83  89  97\n";
            var sr = string.Empty;


            int select;
            int firstNumber;
            int secondNumber;
            string change_1 = "If you want to test a range of numbers - enter 1, ",
                    change_2 = "If one number , press - 2, ",
                    change_3 = "exit - 3",
                    newString = "\n";
            


                Console.WriteLine(String.Format("{0}{1}{2}{3}", newString, change_1, change_2, change_3));
                select = 1;

                if (select == 1)
                {

                    Console.WriteLine("Enter the first number: ");
                    firstNumber = 1;

                    Console.WriteLine("Enter the last number: ");
                    secondNumber = 100;
                sr = printSimpleNumbers(firstNumber, secondNumber);
                 
            }
            Assert.AreEqual(st, sr);
        }
     
    }
    }

