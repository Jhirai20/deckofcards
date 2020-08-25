using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Ndeck = new Deck();
            Player Jeff = new Player("jeff");
            Console.WriteLine(Ndeck.cards.Count+" cards in new deck");

            for (int i = 0; i < 5; i++)
            {
                Jeff.draw(Ndeck);
            }
            Jeff.drawHowMany(Ndeck,3);
            
            Jeff.whathand();
            Jeff.discard(3);
            Jeff.whathand();

        }
    }
}
