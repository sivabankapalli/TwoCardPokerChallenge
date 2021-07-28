using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    [TestClass()]
    public class DetermineWinnerTests
    {
        [TestMethod()]
        public void FinalWinnerTest()
        {
            List<HandComparisonItem> playersList = new List<HandComparisonItem>();
            PokerHand hand1 = new PokerHand(new Card(SUIT.CLUBS, VALUE.EIGHT),
                new Card(SUIT.HEARTS, VALUE.TWO));
            playersList.Add(new HandComparisonItem("Player1", hand1, HandType.HighCard, 2));
            PokerHand hand2 = new PokerHand(new Card(SUIT.HEARTS, VALUE.SEVEN),
                new Card(SUIT.SPADES, VALUE.ACE));
            playersList.Add(new HandComparisonItem("Player2", hand2, HandType.HighCard, 1));
            PokerHand hand3 = new PokerHand(new Card(SUIT.SPADES, VALUE.FIVE),
                new Card(SUIT.CLUBS, VALUE.EIGHT));
            playersList.Add(new HandComparisonItem("Player2", hand3, HandType.HighCard, 2));
            PokerHand hand4 = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.TEN),
                new Card(SUIT.SPADES, VALUE.JACK));
            playersList.Add(new HandComparisonItem("Player1", hand4, HandType.Straight, 1));
            ArrayList result;
            DetermineWinner obj = new DetermineWinner();
            result = obj.FinalWinner(playersList);
            string winner = result[0].ToString().Split(' ')[0];
            Assert.AreEqual("Player1", winner);
        }
    }
}