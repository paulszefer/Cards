using System;

namespace WindowsFormsApplication1.Classes
{
    public enum ECardValue
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class CardValue
    {
        public readonly ECardValue Value;

        public CardValue(int value)
        {
            Value = (ECardValue) value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (!GetType().Equals(obj.GetType()))
                return false;

            CardValue other = (CardValue) obj;
            return (int) Value == (int) other.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public string ToValue()
        {
            return Value.ToString("D");
        }
    }
}
