using System;
using System.Security.AccessControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isSimple()
        {
           bool is_simple;
             var st = "True";
            var sr = string.Empty;
            var number = 100;
            
            
            
            if (number < 2)
            {
                is_simple = false;
            }

            for (var i = 6; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    is_simple = false;
                    break;
                }
            }
            is_simple = true;
           
            sr = sr + is_simple;
            Assert.AreEqual(st, sr);
        }
    }
}
    

