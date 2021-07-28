namespace TwoCardPokerChallenge.Contract
{
    public class HandComparisonItem
    {
        public PokerHand Hand { get; set; }
        public HandType HandType { get; set; }
        public int Rank { get; set; }

        public string PlayerName { get; set; }

        public HandComparisonItem(string name, PokerHand hand, HandType handType)
        {
            PlayerName = name;
            Hand = hand;
            HandType = handType;
        }
        public HandComparisonItem(string name, PokerHand hand, HandType handType, int rank)
        {
            PlayerName = name;
            Hand = hand;
            HandType = handType;
            Rank = rank;
        }
    }
}
