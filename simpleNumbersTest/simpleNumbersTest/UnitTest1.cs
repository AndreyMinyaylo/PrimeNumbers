using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace primeNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var st = "   2   3   5   7  11\n" +
                     "  13  17  19  23  29\n" +
                     "  31  37  41  43  47\n" +
                     "  53  59  61  67  71\n" +
                     "  73  79  83  89  97\n";
            var sr = string.Empty;

            var firstNumber = 1;
            var secondNumber = 100;
            var n = 0;


            {
                if (firstNumber == 1)
                {
                    firstNumber = firstNumber + 1;
                    for (int i = firstNumber; i <= secondNumber; i++)
                    {
                        int cnt = 0;
                        for (int j = 2; j <= i / 2; ++j)
                        {
                            if (i % j == 0)
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
                                sr = sr + (" ");
                                symbolLenght--;
                            }

                            sr = sr + (i);
                            n++;

                            if (n % 5 == 0)
                            {
                                sr = sr + ('\n');
                            }
                        }
                    }
                }


            }
            Assert.AreEqual(st, sr);
        }
    }
}
