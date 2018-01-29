using System;
using Game.Exceptions;
using Game.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTests.Logic
{
    [TestClass]
    public class NumberLogicTest
    {

        [TestMethod]
        [ExpectedException(typeof(PlayLostException), "A player who hesitates or makes a mistake is eliminated from the game.")]
        public void NumberLogicTest_string_ABC_Should_FormatException()
        {
            var actual = NumberLogic.ChoiceValidNumber("ABC");
            Console.WriteLine(actual);

        }

        [TestMethod]
        [ExpectedException(typeof(PlayLostException), "A player who hesitates or makes a mistake is eliminated from the game.")]
        public void NumberLogicTest_string_99999999999999999_Should_OverflowException()
        {
            var actual = NumberLogic.ChoiceValidNumber("99999999999999999");
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void NumberLogicTest_string_3_Should_return_int_3()
        {

            int expected = 3;
            int actual = NumberLogic.ChoiceValidNumber("3");
           
            Assert.AreEqual(expected, actual);
        }

    }
}
