using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    [TestClass]
    public class InputValidationTest
    {
        [TestMethod]
        public void ValidateNoOfPlayersInputTest_ValidInput()
        {
            Utilities obj = new Utilities();
            Assert.AreEqual(false, obj.ValidateNoOfPlayersInput(4));
        }
        [TestMethod]
        public void ValidateNoOfPlayersInputTest__InvalidInputLessthan_2()
        {
            Utilities obj = new Utilities();
            Assert.AreEqual(true, obj.ValidateNoOfPlayersInput(1));
        }
        [TestMethod]
        public void ValidateNoOfPlayersInputTest__InvalidInputGreaterthan_6()
        {
            Utilities obj = new Utilities();
            Assert.AreEqual(true, obj.ValidateNoOfPlayersInput(7));
        }
        [TestMethod]
        public void ValidateNoOfRoundsInputTest_ValidInput()
        {
            Utilities obj = new Utilities();
            Assert.AreEqual(false, obj.ValidateNoOfRoundsInput(4));
        }
        [TestMethod]
        public void ValidateNoOfRoundsInputTest_InvalidInputLessthan_2()
        {
            Utilities obj = new Utilities();
            Assert.AreEqual(true, obj.ValidateNoOfRoundsInput(1));
        }
        [TestMethod]
        public void ValidateNoOfRoundsInputTest_InvalidInputGreaterthan_5()
        {
            Utilities obj = new Utilities();
            Assert.AreEqual(true, obj.ValidateNoOfRoundsInput(6));
        }
    }
}
