using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerPasswordTest
    {
        [Test,
        TestCase("ABD12334", false),
        TestCase("Ab1234", false),
        TestCase("Abcd1234", true),
        TestCase("abcd1234", false),
        TestCase("abcdBCD", false)
         ]
        public void ValidatePassword(string password, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
