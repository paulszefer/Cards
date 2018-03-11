using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Base
{
    public class Player
    {
        public readonly List<Card> Hand;

        public Player(bool computer = false)
        {
            if (computer)
            {

            }
            else
            {

            }

            Hand = new List<Card>();
        }

        public void Draw(Deck deck)
        {
            try
            {
                Hand.Add(deck.Draw());
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("This Player cannot draw. " + e.Message);
            }
        }

        public void DrawTo(int max, Deck deck)
        {
            while (Hand.Count < max) {
                try
                {
                    Hand.Add(deck.Draw());
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("This Player cannot draw. " + e.Message);
                    return;
                }
            }
        }

        public void PlayCard(int index, CardPile pile)
        {
            if (index >= Hand.Count)
                throw new IndexOutOfRangeException("The player has no card at index: " + index + ".");
            Card card = Hand[index];
            Hand.Remove(card);
            pile.Add(card);
        }

        public override string ToString()
        {
            string result = "";
            foreach (Card c in Hand)
            {
                result += c + "\n";
            }
            return result;
        }
    }
}
