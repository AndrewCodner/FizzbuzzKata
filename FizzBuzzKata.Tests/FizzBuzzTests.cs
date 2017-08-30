using FizzbuzzKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
       [Test]
       public void FizzbuzzChecker_GivenIntegeroNumberOne_ShouldReturnStringNumberOne ()
        {
            //Arrange
            int input = 1;
            string expected = "1";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberTwo_ShouldReturnStringNumberTwo()
        {
            //Arrange
            int input = 2;
            string expected = "2";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}
