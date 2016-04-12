using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_one_SimpleNumber
{
    [TestClass]
    public class Test_oneNumber
    {
        [TestMethod]

        public static bool isSimple(int number)
        {
            if (number < 2)
            {
                return false;
            }
            bool is_simple = true;
            for (int i = 2; i < number/2; i++)
            {
                if (number%i == 0)
                {
                    is_simple = false;
                    break;
                }
            }
            return is_simple;
        }


        public static void printSimleNumberEnd()
        {
            Console.WriteLine("!");
            var st = "Number 7 is simple";
            var sr = string.Empty;
            var number = 7;
            while (true)
            {
                Console.WriteLine('\n' + "Enter number and we check number is simple or no or enter 3 to exit:");

                if (number == 3)
                {
                    break;
                }
                bool is_Simple = isSimple(number);
                if (is_Simple == true)
                {
                    sr = sr + "Number " + number + " is simple";
                }
                else
                {
                    sr = sr + "Number " + number + " is not simple";
                }
                Assert.AreEqual(st, sr);
            }
        }
    }


}
