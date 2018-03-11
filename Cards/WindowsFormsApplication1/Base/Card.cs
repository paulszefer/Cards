using System;

namespace Cards.Base
{
    public class Card
    {
        public readonly CardValue Value;
        public readonly CardSuit Suit;

        private Random Random = new Random();

        public Card(int value = -1, int suit = -1)
        {
            if (value == -1)
                Value = new CardValue(Random.Next(Enum.GetValues(typeof(ECardValue)).Length));
            else
                Value = new CardValue(value);

            if (suit == -1)
                Suit = new CardSuit(Random.Next(Enum.GetValues(typeof(ECardSuit)).Length));
            else
                Suit = new CardSuit(suit);
        }

        public Card(CardValue value, CardSuit suit)
        {
            if (value == null)
                throw new ArgumentNullException("The given CardValue was null.");
            if (suit == null)
                throw new ArgumentNullException("The given CardSuit was null.");
            Value = value;
            Suit = suit;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (!GetType().Equals(obj.GetType()))
                return false;

            Card other = (Card) obj;
            if (!Value.Equals(other.Value))
                return false;
            if (!Suit.Equals(other.Suit))
                return false;

            return true;
        }

        public override string ToString()
        {
            return Value.ToString() + " of " + Suit.ToString();
        }
    }
}
