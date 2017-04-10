using Game.Logic;
using Game.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTests.Services
{
    [TestClass()]
    public class FizzbuzzLogicTests
    {
        
        [TestMethod()]
        public void GetFizzBuzzTest_negative_1_Should_return_1()
        {
            var i= 1;

            var expected = "1";
            var actual = FizzBuzzLogic .ValidationRules(i);
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFizzBuzzTest_2_Should_return_2()
        {
            var i = 2;

            var expected = "2";

            var actual = FizzBuzzLogic.ValidationRules(i);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFizzBuzzTest_3_Should_return_Fizz()
        {
            var i = 3;

            var expected = "Fizz";
            
            var actual = FizzBuzzLogic.ValidationRules(i);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetFizzBuzzTest_4_Should_return_4()
        {
            var i = 4;

            var expected = "4";
            
            var actual = FizzBuzzLogic.ValidationRules(i);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetFizzBuzzTest_5_Should_return_Buzz()
        {
            var i = 5;

            var expected = "buzz";

            var actual = FizzBuzzLogic.ValidationRules(i);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetFizzBuzzTest_6_Should_return_Fizz()
        {
            var i = 6;

            var expected = "Fizz";

            var actual = FizzBuzzLogic.ValidationRules(i);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetFizzBuzzTest_30_Should_return_Fizz()
        {
            var i = 30;

            var expected = "Fizzbuzz";

            var actual = FizzBuzzLogic.ValidationRules(i);

            Assert.AreEqual(expected, actual);
        }

    }
}