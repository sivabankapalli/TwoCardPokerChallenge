namespace TwoCardPokerChallenge.Contract
{
    public class HandValidationFault
    {
        public PokerHand Hand { get; set; }
        public PokerHandValidationFaultDescription FaultDescription { get; set; }
    }
}
