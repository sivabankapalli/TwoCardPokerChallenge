using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCardPokerChallenge.Contract;

namespace TwoCardPokerChallenge.Test
{
    [TestClass]
    public class HandValidationFaultTest
    {
        [TestMethod]
        public void Get_Set_HandTest()
        {
            PokerHand hand = new PokerHand(new Card(SUIT.CLUBS, VALUE.ACE),
                new Card(SUIT.DIAMONDS, VALUE.EIGHT));
            HandValidationFault handValidationFault = new HandValidationFault {Hand = hand};
            Assert.AreEqual(hand, handValidationFault.Hand);
        }
       
        [TestMethod]
        public void Get_Set_FaultDescriptionTest()
        {
            PokerHand hand = new PokerHand(new Card(SUIT.CLUBS, VALUE.ACE),
                new Card(SUIT.DIAMONDS, VALUE.EIGHT));
            HandValidationFault handValidationFault = new HandValidationFault
            {
                FaultDescription = PokerHandValidationFaultDescription.HasDuplicateCards
            };
            Assert.AreEqual(1, (int)(Enum.Parse(typeof(PokerHandValidationFaultDescription),handValidationFault.FaultDescription.ToString())));
        }
    }
}
