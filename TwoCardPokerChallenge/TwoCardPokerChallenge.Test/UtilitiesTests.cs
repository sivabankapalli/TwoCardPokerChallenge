using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCardPokerChallenge.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCardPokerChallenge.Contract.Test
{
    [TestClass()]
    public class UtilitiesTests
    {
        [TestMethod()]
        public void CardSuitToSymbolTest_CARD()
        {
           Card card = new Card(SUIT.DIAMONDS,VALUE.ACE);
           Assert.AreEqual("♦", Utilities.CardSuitToSymbol(card));
        }

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

        [TestMethod()]
        public void CardSuitToSymbolTest_SUIT()
        {
            SUIT s = SUIT.HEARTS;
            Assert.AreEqual("♥", Utilities.CardSuitToSymbol(s));
        }

        [TestMethod()]
        public void CardToShortStringTest()
        {
            Card card = new Card(SUIT.DIAMONDS, VALUE.ACE);
            Assert.AreEqual("♦A", Utilities.CardToShortString(card));
        }

        [TestMethod()]
        public void CardValueToShortStringTest_CARD()
        {
            Card card = new Card(SUIT.DIAMONDS, VALUE.KING);
            Assert.AreEqual("K", Utilities.CardValueToShortString(card));
        }

        [TestMethod()]
        public void CardValueToShortStringTest_VALUE()
        {
            VALUE v = VALUE.KING;
            Assert.AreEqual("K", Utilities.CardValueToShortString(v));
        }
        [TestMethod()]
        public void EnumToTitleTest()
        {
            VALUE v = VALUE.EIGHT;
            Assert.AreEqual("E I G H T", Utilities.EnumToTitle(v));
        }

        [TestMethod()]
        public void PokerHandsToShortStringTest()
        {
            PokerHand[] pokerHand = new PokerHand[2];

            pokerHand[0] = new PokerHand(
                new Card(SUIT.DIAMONDS, VALUE.TWO),
                new Card(SUIT.DIAMONDS, VALUE.TEN)
            );
            pokerHand[1] = new PokerHand(
                new Card(SUIT.CLUBS, VALUE.JACK),
                new Card(SUIT.SPADES, VALUE.QUEEN)
            );
            string result = Utilities.PokerHandsToShortString(pokerHand);
            Assert.AreEqual("♦2,♦10 - ♣J,♠Q", result);
        }

    }
}