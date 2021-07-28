using System;
using System.Collections.Generic;
using System.Linq;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge
{
    public class DeckOfCards
    {
        private const int NumOfCards = 52;
        public static List<Card> Cards { get; set; }
        public List<Card> ShuffledCards { get; set; }
        public static List<List<Card>> EachRoundDeckOfCards = new List<List<Card>>();
        public DeckOfCards()
        {
            
        }

        public DeckOfCards(bool shuffleDeck)
        {
            if (shuffleDeck)
            {
                Cards = new List<Card>();
                Cards = (from SUIT suit in Enum.GetValues(typeof(SUIT))
                    from VALUE value in Enum.GetValues(typeof(VALUE))
                    select new Card(suit, value)).ToList();
            }
        }
        public void StoreEachRoundDeckOfCards()
        {
            var result = EachRoundDeckOfCards.Contains(Cards);
            if (result)
            {
                Cards = new List<Card>();
                Cards = (from SUIT suit in Enum.GetValues(typeof(SUIT))
                    from VALUE value in Enum.GetValues(typeof(VALUE))
                    select new Card(suit, value)).ToList();
                ShuffleCards(2);
            }

            EachRoundDeckOfCards.Add(Cards);
        }
        public void ShuffleCards(int numberOfTimes)
        {
            try
            {
                TwoCardPoker.CardsSuffled = 1;
                List<Card> shuffleDeck = new List<Card>();
                Random rand = new Random();
                int p;
                for (int shuffleTimes = 0; shuffleTimes < numberOfTimes; shuffleTimes++)
                {
                    for (int i = 0; i < NumOfCards; i++)
                    {
                        p = rand.Next(0, Cards.Count);
                        shuffleDeck.Add(Cards[p]);
                        Cards.Remove(Cards[p]);
                    }
                    Cards = shuffleDeck;
                    ShuffledCards = Cards;
                }
                //StoreEachRoundDeckOfCards();
            }
            catch(Exception e)
            {
                TwoCardPoker.CardsSuffled = 0;
                var poker = new TwoCardPoker();
                poker.errorMessage.Visible = true;
                poker.errorMessage.Text = $@"Exception Thrown {e.Message}";
            }

        }
    }
}
