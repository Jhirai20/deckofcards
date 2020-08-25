using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name=name;
            Hand=new List<Card>();
            whathand();
        }
        public Card draw(Deck deck)
        {
            Card Ncard= deck.deal();
            Hand.Add(Ncard);
            return Ncard;
        }
        public Card discard(int ind)
        {
            if (ind<0 ||ind>Hand.Count)
            {
                Console.WriteLine("index is out of range");
                return null;
            }
            else
            {
                Card Dcard= Hand[ind];
                Hand.RemoveAt(ind);
                return Dcard;
            }
        }
        public void whathand()
        {
            Console.WriteLine("Player Jeff has "+ Hand.Count+" cards in hand");
            for (int i = 0; i < Hand.Count; i++)
            {
                Console.Write($"{Hand[i].StrVal} of {Hand[i].Suit}, ");
            }
        }
        public List<Card> drawHowMany(Deck deck, int num)
        {
            for (int i = 0; i < num; i++)
            {
                draw(deck);
            }
            return Hand;
        }
    }
}