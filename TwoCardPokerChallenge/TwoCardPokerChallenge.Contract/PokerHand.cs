using System.Collections.Generic;

namespace TwoCardPokerChallenge.Contract
{
    public class PokerHand : List<Card>
    {
        public PokerHand(params Card[] pokerhandCards)
        {
            AddRange(pokerhandCards);
        }
    }
}
