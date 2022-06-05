using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Tests.TestsResult;

namespace UnitTestProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class PasswordStrengthChekerTests
        {
            [TestMethod]
            public void GetEmailStrength_AllCahrs_5Points()
            {
                string email = "haritonovhukk@inbox.ru";
                int expected = 5;
                int actual = proverka.GetEmailStrength(email);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void CheckingForUniqueness_Test()
            {
                string telef = "89607837974";
                int expected = 1;
                int actual = proverka.GetEmailStrength(telef);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
