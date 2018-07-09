using NUnit.Framework;
using System;

namespace NewGameTests
{
    [TestFixture()]
    public class NumberHandlerTest
    {

        /// <summary>
        /// Tests that NumberHandler returns 'Fizz' when passed 3.
        /// </summary>
        [Test()]
        public void TestFizz()
        {
            var expectedResult = "Fizz";
            var nh = new NumberGame.NumberHandlers.NumberHandler();
            var actualResult = nh.GetMessage(3);
            Assert.AreEqual(expectedResult, actualResult, "NumberHandler did not return Fizz when value passed was 3");
        }

        /// <summary>
        /// Tests that NumberHandler returns 'Buzz' when passed 5.
        /// </summary>
        [Test()]
        public void TestBuzz()
        {
            var expectedResult = "Buzz";
            var nh = new NumberGame.NumberHandlers.NumberHandler();
            var actualResult = nh.GetMessage(5);
            Assert.AreEqual(expectedResult, actualResult, "NumberHandler did not return Buzz when value passed was 5");
        }

        /// <summary>
        /// Tests that NumberHandler returns 'FizzBuzz' when passed 15.
        /// </summary>
        [Test()]
        public void TestFizzBuzz()
        {
            var expectedResult = "FizzBuzz";
            var nh = new NumberGame.NumberHandlers.NumberHandler();
            var actualResult = nh.GetMessage(15);
            Assert.AreEqual(expectedResult, actualResult, "NumberHandler did not return FizzBuzz when value passed was 15");
        }

        /// <summary>
        /// Tests that NumberHandler returns '1' when passed 1.
        /// </summary>
        [Test()]
        public void Test1()
        {
            var expectedResult = "1";
            var nh = new NumberGame.NumberHandlers.NumberHandler();
            var actualResult = nh.GetMessage(1);
            Assert.AreEqual(expectedResult, actualResult, "NumberHandler did not return 1 when value passed was 1");
        }
        
    }
}
