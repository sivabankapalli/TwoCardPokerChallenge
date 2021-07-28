using System;
using System.Collections.Generic;
using System.Linq;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge
{
    public class DealCards : DeckOfCards
    {
        public int PlayersCount { get; set; }
        public int Rounds { get; set; }

        private const string ExceptionMessage = "Exception Thrown ";
        public List<List<Card>> PlayerHand;
        public List<Card> DeckOfCards;
        public List<Card> StorePlayerHandList;
        static IHandAssessor assessor = new EvaluateCards();

        public DealCards()
        {
            PlayersCount = 0;
            Rounds = 0;
            PlayerHand = new List<List<Card>>();
            DeckOfCards = new List<Card>();
            StorePlayerHandList = new List<Card>();
            
        }
        public DealCards(int numberOfPlayers,int numberOfRounds)
        {
            PlayersCount = numberOfPlayers;
            Rounds = numberOfRounds;
            PlayerHand = new List<List<Card>>();
            DeckOfCards = new List<Card>();
            StorePlayerHandList = new List<Card>();
        }
        
        public void GetCards()
        {
            if(Cards != null)
            {
                DeckOfCards = Cards;
            }
            else
            {
                DeckOfCards = (from SUIT suit in Enum.GetValues(typeof(SUIT))
                    from VALUE value in Enum.GetValues(typeof(VALUE))
                    select new Card(suit, value)).ToList();
            }
        }

        public List<HandComparisonItem> GetPlayerHand(int numberOfPlayers)
        {
            return GetHands(numberOfPlayers);
        }
        public List<HandComparisonItem> GetHands(int playersCount)
        {
            try
            {
                GetCards();
                PokerHand[] pokerHand = new PokerHand[playersCount];
                for (int player = 0; player < playersCount; player++)
                {
                   PlayerHand.Add(new List<Card>());
                    for (int i = 0; i < 2; i++)
                    {
                        PlayerHand[player].Add(DeckOfCards[0]);
                        StorePlayerHandList.Add(DeckOfCards[0]);
                        DeckOfCards.RemoveAt(0);
                    }

                    pokerHand[player] = new PokerHand(
                new Card(PlayerHand[player][0].Suite, PlayerHand[player][0].Value),
                new Card(PlayerHand[player][1].Suite, PlayerHand[player][1].Value)
                );
                   
                }

                var comparisonItems = assessor.ComparePokerHands(pokerHand);
                return comparisonItems;
            }
            catch (Exception e)
            {
                TwoCardPoker twoCardPoker = new TwoCardPoker();
                //twoCardPoker.errorMessage.Visible = true;
                twoCardPoker.errorMessage.Text = ExceptionMessage + e.Message;
                return null;
            }
        }
    }
}
