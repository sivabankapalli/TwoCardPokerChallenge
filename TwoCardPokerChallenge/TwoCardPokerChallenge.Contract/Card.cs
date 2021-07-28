namespace TwoCardPokerChallenge.Contract
{
    public class Card
    {
        public SUIT Suite { get; set; }
        public VALUE Value { get; set; }
        public Card(SUIT s, VALUE v)
        {
            Suite = s;
            Value = v;
        }
    }
}
