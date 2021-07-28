using System.Collections.Generic;

namespace TwoCardPokerChallenge.Contract
{
    public interface IHandAssessor
    {
        List<HandComparisonItem> ComparePokerHands(params PokerHand[] pokerHands);
        HandType DeterminePokerHandType(PokerHand pokerHand);
        List<HandValidationFault> ValidatePokerHands(params PokerHand[] pokerHands);
    }
}
