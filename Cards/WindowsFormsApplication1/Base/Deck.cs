using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    public class Deck
    {
        public readonly List<Card> Cards;

        private Random Random = new Random();

        public Deck()
        {
            Cards = new List<Card>();
            for (int i = 0; i < 52; i++)
            {
                Cards.Add(new Card(i % 13, i / 13));
            }
        }

        public Deck(int size)
        {
            Cards = new List<Card>();
            for (int i = 0; i < size; i++)
            {
                Cards.Add(new Card(i % 13, i / 13));
            }
        }

        public void Shuffle()
        {
            Card card;
            for (int i = 0; i < Cards.Count; i++)
            {
                card = Cards[Random.Next(i, Cards.Count)];
                Cards.Remove(card);
                Cards.Insert(i, card);
            }
        }

        public Card Draw()
        {
            if (Cards.Count == 0)
            {
                throw new IndexOutOfRangeException("The deck has no cards remaining.");
            }

            Card result = Cards[Random.Next(Cards.Count)];
            Cards.Remove(result);
            return result;
        }

        public List<Card> Draw(int count)
        {
            if (count > Cards.Count)
            {
                throw new IndexOutOfRangeException(String.Format("The deck has fewer than {0} card{1} remaining.", count, count == 1 ? "" : "s"));
            }

            List<Card> result = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Draw());
            }
            return result;
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
