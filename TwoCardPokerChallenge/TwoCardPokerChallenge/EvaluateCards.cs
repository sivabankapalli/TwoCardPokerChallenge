using System;
using System.Collections.Generic;
using System.Linq;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge
{
    public class EvaluateCards : IHandAssessor
    {
        public void ArrangeCards(PokerHand pokerHand)
        {
            //First determine whether the poker hand is a Straight or a Straight Flush.
            bool straight = IsStraight(pokerHand);

            //Sort ascending
            pokerHand.Sort((pokerCard1, pokerCard2) =>
            pokerCard1.Value.CompareTo(pokerCard2.Value));

            //Move Aces to the end if:
            if (!straight || //Not a straight
                pokerHand[1].Value == VALUE.ACE)//Straight with a king at the end
            {
                //Move all Aces To the End
                while (pokerHand[0].Value == VALUE.TWO)
                {
                    pokerHand.Add(pokerHand[0]);
                    pokerHand.RemoveAt(0);
                }
            }
        }

        public PokerHand[] CheckPokerHandsForDuplicateCards(params PokerHand[] pokerHands)
        {
            for (int i = 0; i < pokerHands.Length; i++)
            {
                //Check whether the poker hand contains duplicate cards of itself.
                PokerHand pokerHand = pokerHands[i];
                if (pokerHand.GroupBy(card => new { card.Suite, card.Value }).Count()
                            != pokerHand.Count)
                    return new[] { pokerHand };

                for (int ii = i + 1; ii < pokerHands.Length; ii++)
                {
                    //Check whether cards are duplicated between two poker hands.
                    if (new[] { pokerHand, pokerHands[ii] }.SelectMany(hand => hand)
                        .GroupBy(card => new { card.Suite, card.Value }).Count() !=
                        pokerHand.Count + pokerHands[ii].Count)
                        return new[] { pokerHand, pokerHands[ii] };
                }
            }
            return new PokerHand[0];
        }

        public List<HandComparisonItem> ComparePokerHands(params PokerHand[] pokerHands)
        {
            ValidatePokerHands_private(pokerHands);

            var lstPokerHandComparison = new List<HandComparisonItem>();
            
            pokerHands.ToList().ForEach(hand => lstPokerHandComparison.Add(
            new HandComparisonItem("Player",hand, DeterminePokerHandType(hand))));
            int index = 1;
            foreach (var item in lstPokerHandComparison)
            {
                item.PlayerName += index;
                index++;
            }
            int[] rankRev = new int[lstPokerHandComparison.Count];
            //Sort ascending by poker hand type.
            lstPokerHandComparison.Sort((comparisonItem1, comparisonItem2) =>
            comparisonItem1.HandType.CompareTo(comparisonItem2.HandType));

            //Group by hand type.
            var handTypeGroups = lstPokerHandComparison.GroupBy(comparisonItem =>
            comparisonItem.HandType).ToList();

            //Compare hands in groups.
            int rank = 0;
            handTypeGroups.ForEach(handTypeGroup =>
            {
                //Get comparison items in this group.
                var comparisonItemsInGroup = handTypeGroup.ToList();

                //Rank must be incremented for every group.
                rank++;

                //Process single hand group.
                if (comparisonItemsInGroup.Count == 1)
                    comparisonItemsInGroup[0].Rank = rank;

                //Process multi hand group.
                else
                {
                    //Sort descending by winning hand. Winning hands are listed first.
                    comparisonItemsInGroup.Sort((comparisonItem1, comparisonItem2) => -1 *
                    CompareHandsOfSameType(
                    comparisonItem1.Hand, comparisonItem2.Hand, comparisonItem1.HandType));

                    //Assign current rank to first hand in group.
                    comparisonItemsInGroup[0].Rank = rank;

                    for (int i = 1; i < comparisonItemsInGroup.Count; i++)
                    {
                        //Compare current hand with previous hand.
                        var currentComparisonItem = comparisonItemsInGroup[i];
                        if (CompareHandsOfSameType(comparisonItemsInGroup[i - 1].Hand,
                            currentComparisonItem.Hand, currentComparisonItem.HandType) == 1)
                            rank++;

                        //Assign current rank to current hand in group.
                        currentComparisonItem.Rank = rank;
                    }
                }
            });

            lstPokerHandComparison.Sort((comparisonItem1, comparisonItem2) => -1 *
            comparisonItem1.Rank.CompareTo(comparisonItem2.Rank));
            for (int l = 0; l < lstPokerHandComparison.Count; l++)
            {
                rankRev[l] = lstPokerHandComparison[l].Rank;
            }

            Array.Reverse(rankRev);
            for (int l = 0; l < lstPokerHandComparison.Count; l++)
            {
                lstPokerHandComparison[l].Rank = rankRev[l]-1;
            }
            return lstPokerHandComparison;
        }

        public int CompareHandsOfSameType(PokerHand pokerHand1, PokerHand pokerHand2, HandType pokerHandType)
        {
            //Arrange cards
            ArrangeCards(pokerHand1);
            ArrangeCards(pokerHand2);

            //Compare the hands.
            switch (pokerHandType)
            {
                case HandType.Pair:
                    List<Card> hand1SameCardSet1;
                    FindSetsOfCardsWithSameValue(
                        pokerHand1, out hand1SameCardSet1, out _);

                    List<Card> hand2SameCardSet1;
                    FindSetsOfCardsWithSameValue(
                        pokerHand2, out hand2SameCardSet1, out _);
                    return CompareHandsOfSameType_Helper(
                        hand1SameCardSet1[0], hand2SameCardSet1[0]);
                case HandType.StraightFlush:
                case HandType.Straight:
                    return CompareHandsOfSameType_Helper(pokerHand1[1], pokerHand2[1]);
                case HandType.Flush:
                case HandType.HighCard:
                    for (int i = 1; i >= 0; i--)
                    {
                        int result =
                        CompareHandsOfSameType_Helper(pokerHand1[i], pokerHand2[i]);
                        if (result != 0)
                            return result;
                    }
                    return 0;
            }
            throw new Exception("Hand comparison failed. Check code integrity.");
        }

 
        public int CompareHandsOfSameType_Helper(Card pokerHand1Card, Card pokerHand2Card)
        {
            int pokerHand1CardIntValue = (int)pokerHand1Card.Value;
            int pokerHand2CardIntValue = (int)pokerHand2Card.Value;

            if (pokerHand1Card.Value == VALUE.ACE)
                pokerHand1CardIntValue += (int)VALUE.KING;
            if (pokerHand2Card.Value == VALUE.ACE)
                pokerHand2CardIntValue += (int)VALUE.KING;

            //Compare and return result.
            return pokerHand1CardIntValue > pokerHand2CardIntValue ? 1 :
                pokerHand1CardIntValue == pokerHand2CardIntValue ? 0 : -1;
        }

        void FindSetsOfCardsWithSameValue(PokerHand pokerHand, out List<Card> sameValueSet1, out List<Card> sameValueSet2)
        {
            //Arrange the cards in logical order.
            ArrangeCards(pokerHand);

            //Find sets of cards with the same value.
            int index = 0;
            sameValueSet1 = FindSetsOfCardsWithSameValue_Helper(pokerHand, ref index);
            sameValueSet2 = FindSetsOfCardsWithSameValue_Helper(pokerHand, ref index);
        }
        public List<Card> FindSetsOfCardsWithSameValue_Helper(PokerHand pokerHandArrangedCorrectly, ref int index)
        {
            List<Card> sameCardSet = new List<Card>();
            for (; index < 1; index++)
            {
                Card currentCard = pokerHandArrangedCorrectly[index];
                Card nextCard = pokerHandArrangedCorrectly[index + 1];
                if (currentCard.Value == nextCard.Value)
                {
                    if (sameCardSet.Count == 0)
                        sameCardSet.Add(currentCard);
                    sameCardSet.Add(nextCard);
                }
                else if (sameCardSet.Count > 0)
                {
                    index++;
                    break;
                }
            }
            return sameCardSet;
        }

        public HandType DeterminePokerHandType(PokerHand pokerHand)
        {
            ValidatePokerHands_private(pokerHand);

            //Check whether all cards are in the same suit
            bool allSameSuit = pokerHand.GroupBy(card => card.Suite).Count() == 1;

            //Check whether the Poker Hand Type is: Straight
            bool straight = IsStraight(pokerHand);

            //Determine Poker Hand Type
            if (allSameSuit && straight)
                return HandType.StraightFlush;

            if (allSameSuit)
                return HandType.Flush;

            if (straight)
                return HandType.Straight;

            //Find sets of cards with the same value.
            //Example: QQQ KK
            List<Card> sameCardSet1;
            FindSetsOfCardsWithSameValue(pokerHand, out sameCardSet1, out _);


            if (sameCardSet1.Count == 2)
                return HandType.Pair;

            return HandType.HighCard;
        }
 
        public bool IsStraight(PokerHand pokerHand)
        {
            //Sort ascending
            pokerHand.Sort((pokerCard1, pokerCard2) =>
            pokerCard1.Value.CompareTo(pokerCard2.Value));

            //Determines whether the card values are in sequence.
            return
                //Check that the first two cards are in sequence
                (pokerHand[0].Value == pokerHand[1].Value - 1
                //or the first card is an Ace and the last card is a King.
                || pokerHand[0].Value == VALUE.TWO && pokerHand[1].Value == VALUE.ACE
                );
        }
 
        public List<HandValidationFault> ValidatePokerHands(params PokerHand[] pokerHands)
        {
            List<HandValidationFault> faults = new List<HandValidationFault>();

            //Check card count.
            var pokerHandsWithWrongCardCount =
                        pokerHands.Where(hand => hand.Count != 2).ToList();
            if (pokerHandsWithWrongCardCount.Count > 0)
            {
                pokerHandsWithWrongCardCount.ForEach(hand =>
                faults.Add(new HandValidationFault
                {
                    FaultDescription = PokerHandValidationFaultDescription.WrongCardCount,
                    Hand = hand
                }));
                return faults;
            }


            //Look for duplicates.
            List<PokerHand> pokerHandsWithDuplicates =
                        CheckPokerHandsForDuplicateCards(pokerHands).ToList();
            pokerHandsWithDuplicates.ForEach(hand => faults.Add(new HandValidationFault
            {
                FaultDescription = PokerHandValidationFaultDescription.HasDuplicateCards,
                Hand = hand
            }));
            return faults;
        }

        void ValidatePokerHands_private(params PokerHand[] pokerHands)
        {
            var validationFaults = ValidatePokerHands(pokerHands);
            if (validationFaults.Count > 0)
            {
                string callingMethodName =
                            new System.Diagnostics.StackFrame(1).GetMethod().Name;
                throw new ArgumentException(
                @"Poker hands failed validation: " +
                Utilities.EnumToTitle(validationFaults[0].FaultDescription) +
                @" Call the ValidatePokerHands method for detailed validation feedback.",
                callingMethodName);
            }
        }
    }
}