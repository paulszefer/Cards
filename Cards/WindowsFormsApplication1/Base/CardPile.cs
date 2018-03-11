using System.Collections.Generic;

namespace WindowsFormsApplication1.Classes
{
    public class CardPile
    {
        List<Card> Cards;

        public CardPile()
        {
            Cards = new List<Card>();
        }

        public void Add(Card card)
        {
            Cards.Add(card);
        }

        public void Add(List<Card> cards)
        {
            Cards.AddRange(cards);
        }

        public Card Remove(int index)
        {
            Card removedCard = Cards[index];
            Cards.Remove(removedCard);
            return removedCard;
        }

        public Card Remove(Card card)
        {
            Card removedCard = Cards.Find(c => c.Equals(card));
            Cards.Remove(removedCard);
            return removedCard;
        }

        public List<Card> RemoveAll()
        {
            List<Card> cards = new List<Card>(Cards);
            Cards.Clear();
            return cards;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Card c in Cards)
            {
                result += c + "\n";
            }
            return result;
        }
    }
}