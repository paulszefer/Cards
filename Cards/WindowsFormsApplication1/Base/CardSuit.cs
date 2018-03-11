namespace WindowsFormsApplication1.Classes
{
    public enum ECardSuit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades
    }

    public class CardSuit
    {
        public readonly ECardSuit Value;

        public CardSuit(int value)
        {
            Value = (ECardSuit) value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (!GetType().Equals(obj.GetType()))
                return false;

            CardSuit other = (CardSuit)obj;
            return (int)Value == (int)other.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}