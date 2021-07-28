using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Helper
    {
        public List<HandComparisonItem> PokerHandExpectedData()
        {
            List<HandComparisonItem> cardsExpected = new List<HandComparisonItem>();
            PokerHand hand1 = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.FOUR),
                new Card(SUIT.HEARTS, VALUE.QUEEN));
            cardsExpected.Add(new HandComparisonItem("Player1", hand1, HandType.HighCard, 0));
            PokerHand hand2 = new PokerHand(new Card(SUIT.SPADES, VALUE.NINE),
                new Card(SUIT.CLUBS, VALUE.NINE));
            cardsExpected.Add(new HandComparisonItem("Player2", hand2, HandType.Pair, 1));
            return cardsExpected;
        }

        public List<HandComparisonItem> PokerHandDate()
        {
            DealCards dealCards = new DealCards(2, 2);
            //DeckOfCards deckOfCards = new DeckOfCards(false);

            List<HandComparisonItem> cardResult = dealCards.GetHands(2);
            return cardResult;
        }

        public bool ComparePokerHandsHelper()
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
            List<HandComparisonItem> cardsExpected = new List<HandComparisonItem>();
            PokerHand hand1 = new PokerHand(new Card(SUIT.CLUBS, VALUE.JACK),
                new Card(SUIT.SPADES, VALUE.QUEEN));
            cardsExpected.Add(new HandComparisonItem("Player2", hand1, HandType.Straight, 0));
            PokerHand hand2 = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.TWO),
                new Card(SUIT.DIAMONDS, VALUE.TEN));
            cardsExpected.Add(new HandComparisonItem("Player1", hand2, HandType.Flush, 1));
            bool result = true;
            EvaluateCards objEvaluateCards = new EvaluateCards();
            List<HandComparisonItem> cardResult = objEvaluateCards.ComparePokerHands(pokerHand);
            for (int i = 0; i < cardResult.Count; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    if (cardResult[i].Hand[k].Suite != cardsExpected[i].Hand[k].Suite)
                    {
                        result = false;
                        break;
                    }

                    if (cardResult[i].Hand[k].Value != cardsExpected[i].Hand[k].Value)
                    {
                        result = false;
                        break;
                    }
                }

                if (cardResult[i].HandType != cardsExpected[i].HandType)
                {
                    result = false;
                    break;
                }

                if (cardResult[i].Rank != cardsExpected[i].Rank)
                {
                    result = false;
                    break;
                }

                if (cardResult[i].PlayerName != cardsExpected[i].PlayerName)
                {
                    result = false;
                    break;
                }

            }
            return result;
        }
        public bool GetHandsResult(PokerHand cardsHand)
        {
            List<HandComparisonItem> cardResult = new List<HandComparisonItem>();
            DealCards.Cards = new List<Card>();
            DealCards.Cards = cardsHand;
            cardResult = PokerHandDate();
            List<HandComparisonItem> cardsExpected = new List<HandComparisonItem>();
            cardsExpected = PokerHandExpectedData();
            bool result = true;
            for (int i = 0; i < cardResult.Count; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    if (cardResult[i].Hand[k].Suite != cardsExpected[i].Hand[k].Suite)
                    {
                        result = false;
                        break;
                    }

                    if (cardResult[i].Hand[k].Value != cardsExpected[i].Hand[k].Value)
                    {
                        result = false;
                        break;
                    }
                }

                if (cardResult[i].HandType != cardsExpected[i].HandType)
                {
                    result = false;
                    break;
                }

                if (cardResult[i].Rank != cardsExpected[i].Rank)
                {
                    result = false;
                    break;
                }

                if (cardResult[i].PlayerName != cardsExpected[i].PlayerName)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public bool GetPlayerHandResult(PokerHand cardsHand)
        {
            return GetHandsResult(cardsHand);
        }
    }
}
