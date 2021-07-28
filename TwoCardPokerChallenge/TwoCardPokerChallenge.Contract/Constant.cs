namespace TwoCardPokerChallenge.Contract
{
    public enum SUIT
    {
        SPADES,
        CLUBS,
        HEARTS,
        DIAMONDS
    }
    public enum VALUE
    {
        TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN,
        EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }

    public enum HandType
    {
        StraightFlush = 1,
        Flush = 2,
        Straight = 3,
        Pair = 4,
        HighCard = 5
    }

    public enum PokerHandValidationFaultDescription
    {
        HasDuplicateCards = 1,
        JokersNotAllowed = 2,
        WrongCardCount = 3
    }
}
