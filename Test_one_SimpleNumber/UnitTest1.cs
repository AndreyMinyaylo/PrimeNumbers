using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Test_one_SimpleNumber
{
  
    public class Test_oneNumber
    {

        public static bool isSimple(int number)
        {
            if (number < 2)
            {
                return false;
            }
            bool is_Simple = true;
            for (int i = 2; i < number; i++)
            {
                if (number%i == 0)
                {
                    is_Simple = false;
                    break;
                }
            }
            return is_Simple;
        }

        
        [TestCase(10, "Number 10 is not simple")]
        [TestCase(7, "Number 7 is simple")]
        [TestCase(4, "Number 4 is not simple")]
        [TestCase(17, "Number 17 is simple")]
        public void printSimleNumberEnd(int number, string st)
            {
            string newString = "\n", checkString = "Enter number and we check number is simple or no or enter 3 to exit:";
            //var number = 7;
           // var st = "Number 7 is simple";
            var sr = string.Empty;
            Console.Write("\nEnter number and we check number is simple or no or enter 3 to exit:");
            var sr_1 = string.Empty;
            
                while (true)
                {

                Console.Write(String.Format("{0}{1}", newString, checkString));

                if (number == 3)
                    {
                        break;
                    }
              
                bool is_Simple = isSimple(number);
                if (is_Simple == true)
                    {
                        sr = string.Format("Number {0} is simple", number);

                }
                    else
                    {
                        sr = string.Format("Number {0} is not simple", number);
                }
                break;
            }
            
            Assert.AreEqual(st, sr);
        }
        }
  }
