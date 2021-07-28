using System;
using System.Linq;
using System.Text;

namespace TwoCardPokerChallenge.Contract
{
    public class Utilities
    {

        public bool ValidateNoOfPlayersInput(int noOfPlayers)
        {
            return (noOfPlayers < 2 || noOfPlayers > 6);
        }

        public bool ValidateNoOfRoundsInput(int noOfRounds)
        {
            return (noOfRounds < 2 || noOfRounds > 5);
        }
 
        public static string CardSuitToSymbol(Card card)
        {
            return CardSuitToSymbol(card.Suite);
        }

        public static string CardSuitToSymbol(SUIT cardSuit)
        {
            switch (cardSuit)
            {
                case SUIT.CLUBS:
                    return "♣";
                case SUIT.DIAMONDS:
                    return "♦";
                case SUIT.HEARTS:
                    return "♥";
                case SUIT.SPADES:
                    return "♠";
            }
            return "";
        }

        public static string CardToShortString(Card card)
        {
            return CardSuitToSymbol(card)+CardValueToShortString(card);
        }

        public static string CardValueToShortString(Card card)
        {
            return CardValueToShortString(card.Value);
        }

        public static string CardValueToShortString(VALUE cardValue)
        {
            string shortString = (int)cardValue > 1 && (int)cardValue < 11 ?
            ((int)cardValue).ToString() : EnumToTitle(cardValue)[0].ToString();
            return shortString;
        }

        public static string EnumToTitle(Enum enumToConvert)
        {
            return System.Text.RegularExpressions.Regex
            .Replace(enumToConvert.ToString(), "[A-Z]", " $0").Trim();
        }

        public static string PokerHandsToShortString(params PokerHand[] pokerHands)
        {
            StringBuilder sb = new StringBuilder();
            pokerHands.ToList().ForEach(hand=> {
                hand.ForEach(card => sb.Append(CardToShortString(card) + ','));

                if (hand.Count > 0)
                    sb.Remove(sb.Length - 1, 1);

                sb.Append(" - ");
            });

            if (pokerHands.Length > 0)
                sb.Remove(sb.Length - 3, 3);

            return sb.ToString();
        }

    }
}
