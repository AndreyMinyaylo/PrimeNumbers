using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_one_SimpleNumber
{
    [TestClass]
    public class Test_oneNumber
    {

        public static bool isSimple(int number)
        {
            if (number < 2)
            {
                return false;
            }
            bool is_Simple = true;
            for (int i = 2; i < number/2; i++)
            {
                if (number%i == 0)
                {
                    is_Simple = false;
                    break;
                }
            }
            return is_Simple;
        }

        [TestMethod]
            public void printSimleNumberEnd()
            {
            string newString = "\n", checkString = "Enter number and we check number is simple or no or enter 3 to exit:";
            var number = 7;
            var st = "Number 7 is simple";
            var sr = string.Empty;
            var st_1 = "\nEnter number and we check number is simple or no or enter 3 to exit:";
            var sr_1 = string.Empty;
            
                while (true)
                {

                    sr_1 = newString + checkString;
                    
                if (number == 3)
                    {
                        break;
                    }
              
                bool is_Simple = isSimple(number);
                if (is_Simple == true)
                    {
                        sr = "Number " +number+" is simple";
                    
                    }
                    else
                    {
                        sr = "Number "+number+" is not simple";
                    }
                break;
            }
            Assert.AreEqual(st_1, sr_1);
            Assert.AreEqual(st, sr);
        }
        }
  }
