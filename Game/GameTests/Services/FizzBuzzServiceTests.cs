using System;
using System.Collections.Generic;
using System.Linq;
using Game.Exceptions;
using Game.IServices;
using Game.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTests.Services
{
    [TestClass()]
    public class FizzBuzzServiceTests
    {

        private IFizzBuzzService _fizzBuzzService;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestCleanup()]
        public void Cleanup() {
            _fizzBuzzService = null;
        }

        [TestMethod()]
        [ExpectedException(typeof(PlayLostException), "A player who hesitates or makes a mistake is eliminated from the game.")]
        public void GetFizzBuzzTest_0_Should_return_exception()
        {
            var i = 0;
            var actual = _fizzBuzzService.GetFizzBuzz(i);
            Console.WriteLine(actual);
        }

        [TestMethod()]
        public void GetFizzBuzzTest_1_Should_return_1()
        {
            var i = 1;

            var expected_1 = "1";
            var lenExpected = 1;

            var actual = _fizzBuzzService.GetFizzBuzz(i);

            Assert.IsNotNull(actual);
            var enumerable = actual as IList<string> ?? actual.ToList();
            Assert.AreEqual(lenExpected,enumerable.Count());
            
            Assert.AreEqual(expected_1, enumerable.ElementAt(0));
        }

        [TestMethod()]
        public void GetFizzBuzzTest_2_Should_return_2()
        {
            var i = 2;

            var expected_1 = "1";
            var expected_2 = "2";
            var lenExpected = 2;

            var actual = _fizzBuzzService.GetFizzBuzz(i);

            Assert.IsNotNull(actual);
            var enumerable = actual as IList<string> ?? actual.ToList();
            Assert.AreEqual(lenExpected, enumerable.Count());

            Assert.AreEqual(expected_1, enumerable.ElementAt(0));
            Assert.AreEqual(expected_2, enumerable.ElementAt(1));
        }

        [TestMethod()]
        public void GetFizzBuzzTest_3_Should_return_Fizz()
        {
            var i = 3;
            
            var expected_1 = "1";
            var expected_2 = "2";
            var expected_3 = "Fizz";
            var lenExpected = 3;

            var actual = _fizzBuzzService.GetFizzBuzz(i);

            Assert.IsNotNull(actual);
            var enumerable = actual as IList<string> ?? actual.ToList();
            Assert.AreEqual(lenExpected, enumerable.Count());

            Assert.AreEqual(expected_1, enumerable.ElementAt(0));
            Assert.AreEqual(expected_2, enumerable.ElementAt(1));
            Assert.AreEqual(expected_3, enumerable.ElementAt(2));
        }


        [TestMethod()]
        public void GetFizzBuzzTest_4_Should_return_4()
        {
            var i = 4;

            var expected_1 = "1";
            var expected_2 = "2";
            var expected_3 = "Fizz";
            var expected_4 = "4";
            var lenExpected = 4;

            var actual = _fizzBuzzService.GetFizzBuzz(i);

            Assert.IsNotNull(actual);
            var enumerable = actual as IList<string> ?? actual.ToList();
            Assert.AreEqual(lenExpected, enumerable.Count());

            Assert.AreEqual(expected_1, enumerable.ElementAt(0));
            Assert.AreEqual(expected_2, enumerable.ElementAt(1));
            Assert.AreEqual(expected_3, enumerable.ElementAt(2));
            Assert.AreEqual(expected_4, enumerable.ElementAt(3));
        }


        [TestMethod()]
        public void GetFizzBuzzTest_5_Should_return_buzz()
        {
            var i = 5;

            var expected_1 = "1";
            var expected_2 = "2";
            var expected_3 = "Fizz";
            var expected_4 = "4";
            var expected_5 = "buzz";
            var lenExpected = 5;

            var actual = _fizzBuzzService.GetFizzBuzz(i);

            Assert.IsNotNull(actual);
            var enumerable = actual as IList<string> ?? actual.ToList();
            Assert.AreEqual(lenExpected, enumerable.Count());

            Assert.AreEqual(expected_1, enumerable.ElementAt(0));
            Assert.AreEqual(expected_2, enumerable.ElementAt(1));
            Assert.AreEqual(expected_3, enumerable.ElementAt(2));
            Assert.AreEqual(expected_4, enumerable.ElementAt(3));
            Assert.AreEqual(expected_5, enumerable.ElementAt(4));
        }


        [TestMethod()]
        public void GetFizzBuzzTest_6_Should_return_Fizz()
        {
            var i = 6;

            var expected_1 = "1";
            var expected_2 = "2";
            var expected_3 = "Fizz";
            var expected_4 = "4";
            var expected_5 = "buzz";
            var expected_6 = "Fizz";
            var lenExpected = 6;
            
            var actual = _fizzBuzzService.GetFizzBuzz(i);

            Assert.IsNotNull(actual);
            var enumerable = actual as IList<string> ?? actual.ToList();
            Assert.AreEqual(lenExpected, enumerable.Count());

            Assert.AreEqual(expected_1, enumerable.ElementAt(0));
            Assert.AreEqual(expected_2, enumerable.ElementAt(1));
            Assert.AreEqual(expected_3, enumerable.ElementAt(2));
            Assert.AreEqual(expected_4, enumerable.ElementAt(3));
            Assert.AreEqual(expected_5, enumerable.ElementAt(4));
            Assert.AreEqual(expected_6, enumerable.ElementAt(5));
        }


        [TestMethod()]
        public void GetFizzBuzzTest_30_Should_return_()
        {
            var i = 30;

            var expected_1 = "1";
            var expected_2 = "2";
            var expected_3 = "Fizz";
            var expected_4 = "4";
            var expected_5 = "buzz";
            var expected_6 = "Fizz";
            //...
            var expected_30 = "Fizzbuzz";
            var lenExpected = 30;
            
            var actual = _fizzBuzzService.GetFizzBuzz(i);

            Assert.IsNotNull(actual);
            var enumerable = actual as IList<string> ?? actual.ToList();
            Assert.AreEqual(lenExpected, enumerable.Count());

            Assert.AreEqual(expected_1, enumerable.ElementAt(0));
            Assert.AreEqual(expected_2, enumerable.ElementAt(1));
            Assert.AreEqual(expected_3, enumerable.ElementAt(2));
            Assert.AreEqual(expected_4, enumerable.ElementAt(3));
            Assert.AreEqual(expected_5, enumerable.ElementAt(4));
            Assert.AreEqual(expected_6, enumerable.ElementAt(5));
            //...
            Assert.AreEqual(expected_30, enumerable.ElementAt(29));
        }
    }
}