using System;
using System.Collections.Generic;
using System.Linq;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    class Constants
    {
        public List<Card> DeckOfCardsTest;
        public Constants()
        {
            DeckOfCardsTest = new List<Card>();
            DeckOfCardsTest = (from SUIT suit in Enum.GetValues(typeof(SUIT))
                from VALUE value in Enum.GetValues(typeof(VALUE))
                select new Card(suit, value)).ToList();
        }
    }
}
