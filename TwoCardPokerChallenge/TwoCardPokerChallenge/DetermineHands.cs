using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoCardPokerChallenge;

namespace TwoCardPokerChallenge
{
    class CardSuits
    {
        public enum PokerHandType
        {
            HighCard = 1,
            Pair,
            Straight,
            Flush,
            StraightFlush
        }
        public enum CardSuit
        {
            Club = 0,
            Diamond = 1,
            Heart = 2,
            Spade = 3,
            Joker = 4
        }

        private CardSuit suit;

        public CardSuit GetSuit()
        {
            return this.suit;
        }

        public void SetSuit(CardSuit value)
        {
            this.suit = value;
        }
    }

    class DetermineHands : CardSuits
    {
        public DetermineHands()
        {
        }
       
        void ArrangeCards(List<Card> pokerHand)
        {
            //First determine whether the poker hand is a Straight or a Straight Flush.
            //The IsStraight function also sorts the Poker Hand in ascending order.
            bool straight = IsStraight(pokerHand);

            //Move Aces to the end if:
            if (!straight || //Not a straight
                pokerHand[4].Value == Card.VALUE.KING.ToString())//Straight with a king at the end
            {
                //Move all Aces To the End
                while (pokerHand[0].Value == Card.VALUE.ACE.ToString())
                {
                    pokerHand.Add(pokerHand[0]);
                    pokerHand.RemoveAt(0);
                }
            }
        }
        bool IsStraight(List<Card> pokerHand)
        {
            //Sort ascending
            pokerHand.Sort((pokerCard1, pokerCard2) =>
                String.Compare(pokerCard1.Value, pokerCard2.Value, StringComparison.Ordinal));

            //Determines whether the card values are in sequence.
            return
                //Check whether the last 4 cards are in sequence.
                (int)(Enum.Parse(typeof(Card.VALUE), pokerHand[1].Value)) == (int)(Enum.Parse(typeof(Card.VALUE), pokerHand[2].Value))-1;
        }

        /// <summary>
        /// Determines the poker hand type. For example: Straight Flush or Four of a Kind.
        /// </summary>
        /// <param name="pokerHand">The poker hand to be evaluated.</param>
        /// <returns>The poker hand type.
        /// For example: Straight Flush or Four of a Kind.</returns>
        public PokerHandType DeterminePokerHandType(List<Card> pokerHand)
        {
            //Check whether all cards are in the same suit
            bool allSameSuit = pokerHand.GroupBy(card => card.Suite).Count() == 1;

            //Check whether the Poker Hand Type is: Straight
            bool straight = IsStraight(pokerHand);

            //Determine Poker Hand Type
            if (allSameSuit && straight)
                return PokerHandType.StraightFlush;

            if (allSameSuit)
                return PokerHandType.Flush;

            if (straight)
                return PokerHandType.Straight;

            //Find sets of cards with the same value.
            //Example: QQQ KK
            List<int> sameCardSet1, sameCardSet2;
            FindSetsOfCardsWithSameValue(pokerHand, out sameCardSet1, out sameCardSet2);


            if (sameCardSet1.Count == 2)
                return PokerHandType.Pair;

            return PokerHandType.HighCard;
        }

        void FindSetsOfCardsWithSameValue(List<Card> pokerHand, out List<int> sameValueSet1, out List<int> sameValueSet2)
        {
            //Arrange the cards in logical order.
            ArrangeCards(pokerHand);

            //Find sets of cards with the same value.
            int index = 0;
            sameValueSet1 = FindSetsOfCardsWithSameValue_Helper(pokerHand, ref index);
            sameValueSet2 = FindSetsOfCardsWithSameValue_Helper(pokerHand, ref index);
        }
        List<int> FindSetsOfCardsWithSameValue_Helper(List<Card> pokerHand_ArrangedCorrectly, ref int index)
        {
            List<int> sameCardSet = new List<int>();
            for (; index < 4; index++)
            {
                int currentCard_intValue = (int)Enum.Parse(typeof(Card.VALUE),pokerHand_ArrangedCorrectly[index].Value);
                int nextCard_intValue = (int)Enum.Parse(typeof(Card.VALUE), pokerHand_ArrangedCorrectly[index + 1].Value);
                if (currentCard_intValue == nextCard_intValue)
                {
                    if (sameCardSet.Count == 0)
                        sameCardSet.Add(currentCard_intValue);
                    sameCardSet.Add(currentCard_intValue);
                }
                else if (sameCardSet.Count > 0)
                {
                    index++;
                    break;
                }
            }
            return sameCardSet;
        }
    }

    public interface IPokerHandAssessor
    {
        List<PokerHandComparisonItem> ComparePokerHands(List<List<Card>> pokerHands);
        CardSuits.PokerHandType DeterminePokerHandType(List<Card> pokerHand);
        List<PokerHandValidationFault> ValidatePokerHands(List<List<Card>> pokerHands);
    }
    public class PokerHandComparisonItem
    {
        public List<Card> Hand { get; set; }
        public CardSuits.PokerHandType HandType { get; set; }
        public int Rank { get; set; }

        public PokerHandComparisonItem()
        { }
        public PokerHandComparisonItem(List<Card> Hand)
        {
            this.Hand = Hand;
        }
        public PokerHandComparisonItem(List<Card> Hand, CardSuits.PokerHandType HandType)
        {
            this.Hand = Hand;
            this.HandType = HandType;
        }
        public PokerHandComparisonItem(List<Card> Hand, CardSuits.PokerHandType HandType, int Rank)
        {
            this.Hand = Hand;
            this.HandType = HandType;
            this.Rank = Rank;
        }
    }
    public enum PokerHandValidationFaultDescription
    {
        HasDuplicateCards = 1,
        JokersNotAllowed = 2,
        WrongCardCount = 3
    }
    public class PokerHandValidationFault
    {
        public List<Card> Hand { get; set; }
        public PokerHandValidationFaultDescription FaultDescription { get; set; }

        public List<PokerHandValidationFault> ValidatePokerHands(List<List<Card>> pokerHands)
        {
            List<PokerHandValidationFault> faults = new List<PokerHandValidationFault>();

            //Check card count.
            var pokerHandsWithWrongCardCount =
                pokerHands.Where(hand => hand.Count != 5).ToList();
            if (pokerHandsWithWrongCardCount.Count > 0)
            {
                pokerHandsWithWrongCardCount.ForEach(hand =>
                    faults.Add(new PokerHandValidationFault
                    {
                        FaultDescription = PokerHandValidationFaultDescription.WrongCardCount,
                        Hand = hand
                    }));
                return faults;
            }

            //Look for duplicates.
            List<List<Card>> pokerHandsWithDuplicates =
                CheckPokerHandsForDuplicateCards(pokerHands).ToList();
            pokerHandsWithDuplicates.ForEach(hand => faults.Add(new PokerHandValidationFault
            {
                FaultDescription = PokerHandValidationFaultDescription.HasDuplicateCards,
                Hand = hand
            }));
            return faults;
        }

        List<List<Card>> CheckPokerHandsForDuplicateCards(List<List<Card>> pokerHands)
        {
            for (int i = 0; i < pokerHands.Count; i++)
            {
                //Check whether the poker hand contains duplicate cards of itself.
                List<Card> pokerHand = pokerHands[i];
                if (pokerHand.GroupBy(card => new { card.Suite, card.Value }).Count()
                    != pokerHand.Count)
                    return new List<List<Card>> { pokerHand };

                for (int ii = i + 1; ii < pokerHands.Count; ii++)
                {
                    //Check whether cards are duplicated between two poker hands.
                    if (new List<List<Card>> { pokerHand, pokerHands[ii] }.SelectMany(hand => hand)
                            .GroupBy(card => new { card.Suite, card.Value }).Count() !=
                        pokerHand.Count + pokerHands[ii].Count)
                        return new List<List<Card>> { pokerHand, pokerHands[ii] };
                }
            }
            return new List<List<Card>>{pokerHands[0]};
        }

        public List<PokerHandValidationFault> ValidatePokerHands(List<List<Card>> pokerHands)
        {
            List<PokerHandValidationFault> faults = new List<PokerHandValidationFault>();

            //Check card count.
            var pokerHandsWithWrongCardCount =
                pokerHands.Where(hand => hand.Count != 5).ToList();
            if (pokerHandsWithWrongCardCount.Count > 0)
            {
                pokerHandsWithWrongCardCount.ForEach(hand =>
                    faults.Add(new PokerHandValidationFault
                    {
                        FaultDescription = PokerHandValidationFaultDescription.WrongCardCount,
                        Hand = hand
                    }));
                return faults;
            }

            //Look for duplicates.
            List<List<Card>> pokerHandsWithDuplicates =
                CheckPokerHandsForDuplicateCards(pokerHands).ToList();
            pokerHandsWithDuplicates.ForEach(hand => faults.Add(new PokerHandValidationFault
            {
                FaultDescription = PokerHandValidationFaultDescription.HasDuplicateCards,
                Hand = hand
            }));
            return faults;
        }
    }
  
}