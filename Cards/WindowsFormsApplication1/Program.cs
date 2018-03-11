using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Deck d = new Deck(13);
            Player p = new Player();
            CardPile cp = new CardPile();

            Console.WriteLine("Deck\n" + d);
            d.Shuffle();
            Console.WriteLine("Deck\n" + d);
            p.DrawTo(6, d);
            Console.WriteLine("Deck\n" + d);
            Console.WriteLine("Player\n" + p);
            p.PlayCard(2, cp);
            Console.WriteLine("Deck\n" + d);
            Console.WriteLine("Player\n" + p);
            Console.WriteLine("CardPile\n" + cp);
            p.PlayCard(2, cp);
            Console.WriteLine("Deck\n" + d);
            Console.WriteLine("Player\n" + p);
            Console.WriteLine("CardPile\n" + cp);
        }
    }
}
