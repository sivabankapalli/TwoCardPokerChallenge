using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    [TestClass()]
    public class EvaluateCardsTests
    {
        [TestMethod()]
        public void CheckPokerHandsForDuplicateCardsTest()
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


            EvaluateCards objEvaluateCards = new EvaluateCards();
            
            Assert.AreEqual(0, objEvaluateCards.CheckPokerHandsForDuplicateCards(pokerHand).Length);
        }

        [TestMethod()]
        public void ComparePokerHandsTest()
        {
            Helper objHelper = new Helper();
            Assert.AreEqual(true, objHelper.ComparePokerHandsHelper());
        }

        [TestMethod()]
        public void CompareHandsOfSameTypeTest()
        {
            PokerHand pokerHand1;
            pokerHand1 = new PokerHand(new Card(SUIT.DIAMONDS,VALUE.SIX),
                new Card(SUIT.CLUBS,VALUE.ACE));
            PokerHand pokerHand2;
            pokerHand2 = new PokerHand(new Card(SUIT.HEARTS, VALUE.FOUR),
                new Card(SUIT.CLUBS, VALUE.KING));

            EvaluateCards evaluateCards = new EvaluateCards();
            int result;
            result = evaluateCards.CompareHandsOfSameType(pokerHand1, pokerHand2, HandType.HighCard);
            Assert.AreEqual(1,result);
        }

        [TestMethod()]
        public void CompareHandsOfSameType_HelperTest()
        {
            Card card1 = new Card(SUIT.CLUBS, VALUE.ACE);
            Card card2 = new Card(SUIT.CLUBS, VALUE.KING);
            EvaluateCards obj = new EvaluateCards();
            int result;
            result = obj.CompareHandsOfSameType_Helper(card1, card2);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void FindSetsOfCardsWithSameValue_HelperTest_SameValue()
        {
            PokerHand pokerHand1;
            pokerHand1 = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.SIX),
                new Card(SUIT.CLUBS, VALUE.SIX));
            List<Card> sameValueSet1;
            EvaluateCards obj = new EvaluateCards();
            int index = 0;
            sameValueSet1 = obj.FindSetsOfCardsWithSameValue_Helper(pokerHand1, ref index);
            Assert.AreEqual(2, sameValueSet1.Count);
        }
        [TestMethod()]
        public void FindSetsOfCardsWithSameValue_HelperTest_NotSameValue()
        {
            PokerHand pokerHand1;
            pokerHand1 = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.SIX),
                new Card(SUIT.CLUBS, VALUE.ACE));
            List<Card> sameValueSet1;
            EvaluateCards obj = new EvaluateCards();
            int index = 0;
            sameValueSet1 = obj.FindSetsOfCardsWithSameValue_Helper(pokerHand1, ref index);
            Assert.AreEqual(0, sameValueSet1.Count);
        }
        [TestMethod()]
        public void DeterminePokerHandTypeTest()
        {
            PokerHand pokerHand1;
            pokerHand1 = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.SIX),
                new Card(SUIT.CLUBS, VALUE.ACE));
            EvaluateCards obj = new EvaluateCards();
            HandType result = obj.DeterminePokerHandType(pokerHand1);

            Assert.AreEqual(HandType.HighCard, result);
        }

        [TestMethod()]
        public void IsStraightTest()
        {
            PokerHand pokerHand1;
            pokerHand1 = new PokerHand(new Card(SUIT.DIAMONDS, VALUE.TWO),
                new Card(SUIT.DIAMONDS, VALUE.TEN));

            EvaluateCards obj = new EvaluateCards();
            bool result;
            result = obj.IsStraight(pokerHand1);
            Assert.AreEqual(false,result);
        }

        [TestMethod()]
        public void ValidatePokerHandsTest()
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

            EvaluateCards obj = new EvaluateCards();
            int count = obj.ValidatePokerHands(pokerHand).Count;
            Assert.AreEqual(0,count);
        }
    }
}