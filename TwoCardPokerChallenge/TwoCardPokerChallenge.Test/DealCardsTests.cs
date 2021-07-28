using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    [TestClass()]
    public class DealCardsTests
    {
        [TestMethod()]
        [ExcludeFromCodeCoverage]
        public void GetCardsTest_Success()
        {

            DealCards dealCards = new DealCards(2, 2);
            Constants obj = new Constants();
            DeckOfCards deckOfCards = new DeckOfCards(true);
            dealCards.GetCards();
            bool result = true;
            for (int i = 0; i < dealCards.DeckOfCards.Count; i++)
            {
                if (dealCards.DeckOfCards[i].Suite != obj.DeckOfCardsTest[i].Suite)
                {
                    result = false;
                    break;
                }
                if (dealCards.DeckOfCards[i].Value != obj.DeckOfCardsTest[i].Value)
                {
                    result = false;
                    break;
                }
            }
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        [ExcludeFromCodeCoverage]
        public void GetCardsTest_Failure()
        {
            DealCards dealCards = new DealCards(2, 2);
            Constants obj = new Constants();
            obj.DeckOfCardsTest[0].Suite = SUIT.HEARTS;
            obj.DeckOfCardsTest[0].Value = VALUE.EIGHT;
            var deckOfCards = new DeckOfCards(true);
            dealCards.GetCards();
            bool result = true;
            for (int i = 0; i < dealCards.DeckOfCards.Count; i++)
            {
                if (dealCards.DeckOfCards[i].Suite != obj.DeckOfCardsTest[i].Suite)
                {
                    result = false;
                    break;
                }
                if (dealCards.DeckOfCards[i].Value != obj.DeckOfCardsTest[i].Value)
                {
                    result = false;
                    break;
                }
            }
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void GetHandsTest_Success()
        {
            PokerHand Cards = new PokerHand();
            Cards = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.FOUR),
                new Card(SUIT.HEARTS, VALUE.QUEEN),
                new Card(SUIT.SPADES, VALUE.NINE),
                new Card(SUIT.CLUBS, VALUE.NINE));
            Helper objHelper = new Helper();
            Assert.AreEqual(true, objHelper.GetHandsResult(Cards));
        }

        [TestMethod()]
        public void GetHandsTest_Invalid()
        {
            PokerHand Cards;
            Cards = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.FOUR),
                new Card(SUIT.SPADES, VALUE.QUEEN),
                new Card(SUIT.SPADES, VALUE.NINE),
                new Card(SUIT.CLUBS, VALUE.NINE));

            Helper objHelper = new Helper();
            Assert.AreEqual(false, objHelper.GetHandsResult(Cards));
        }
        [TestMethod()]
        public void GetPlayerHandTest()
        {
            PokerHand Cards;
            Cards = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.FOUR),
                new Card(SUIT.HEARTS, VALUE.QUEEN),
                new Card(SUIT.SPADES, VALUE.NINE),
                new Card(SUIT.CLUBS, VALUE.NINE));

            Helper objHelper = new Helper();
            Assert.AreEqual(true, objHelper.GetHandsResult(Cards));
        }

        [TestMethod()]
        public void GetPlayerHandTest_Invalid()
        {
            PokerHand Cards;
            Cards = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.FOUR),
                new Card(SUIT.SPADES, VALUE.QUEEN),
                new Card(SUIT.SPADES, VALUE.NINE),
                new Card(SUIT.CLUBS, VALUE.NINE));

            Helper objHelper = new Helper();
            Assert.AreEqual(false, objHelper.GetPlayerHandResult(Cards));
        }

        [TestMethod()]
        public void DealCardsTest()
        {
            DealCards obj = new DealCards();
            Assert.AreEqual(0,obj.PlayersCount);
        }
    }
}