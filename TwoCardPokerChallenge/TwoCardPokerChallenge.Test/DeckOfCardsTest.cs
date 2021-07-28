using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    [TestClass]
    public class DeckOfCardsTest
    {
        [TestMethod]
        public void ShuffleCardsTest_Valid_2attempts()
        {
            DeckOfCards obj = new DeckOfCards(true);
            List<Card> cardsInitialise = DeckOfCards.Cards;
            obj.ShuffleCards(2);
            List<Card> shuffeledCards = DeckOfCards.Cards;
            Assert.AreNotSame(cardsInitialise, shuffeledCards);
        }
        [TestMethod]
        public void ShuffleCardsTest_valid_4attempts()
        {
            DeckOfCards obj = new DeckOfCards(true);
            List<Card> cardsInitialise = DeckOfCards.Cards;
            obj.ShuffleCards(4);
            List<Card> shuffeledCards = DeckOfCards.Cards;
            Assert.AreNotSame(cardsInitialise, shuffeledCards);
        }
    }
}
