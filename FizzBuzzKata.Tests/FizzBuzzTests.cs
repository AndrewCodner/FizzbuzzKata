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
        public void FizzbuzzChecker_GivenIntegeroNumberOne_ShouldReturnStringNumberOne()
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

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberThree_ShouldReturnStringFizz()
        {
            //Arrange
            int input = 3;
            string expected = "Fizz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberFour_ShouldReturnStringFour()
        {
            //Arrange
            int input = 4;
            string expected = "4";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberFive_ShouldReturnStringBuzz()
        {
            //Arrange
            int input = 5;
            string expected = "Buzz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberSix_ShouldReturnStringFizz()
        {
            //Arrange
            int input = 6;
            string expected = "Fizz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberNine_ShouldReturnStringFizz()
        {
            //Arrange
            int input = 9;
            string expected = "Fizz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberTen_ShouldReturnStringBuzz()
        {
            //Arrange
            int input = 10;
            string expected = "Buzz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberFifthteen_ShouldReturnStringFizzBuzz()
        {
            //Arrange
            int input = 15;
            string expected = "FizzBuzz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberTwenty_ShouldReturnStringBuzz()
        {
            //Arrange
            int input = 20;
            string expected = "Buzz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberThirty_ShouldReturnStringFizzbuzz()
        {
            //Arrange
            int input = 30;
            string expected = "FizzBuzz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void FizzbuzzChecker_GivenIntegeroNumberSeventyFive_ShouldReturnStringFizzbuzz()
        {
            //Arrange
            int input = 75;
            string expected = "FizzBuzz";
            //Act
            FizzBuzz fizzbuzz = new FizzBuzz();
            var result = fizzbuzz.FizzbuzzChecker(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
