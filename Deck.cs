using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List <Card> cards;
        public Deck()
        {
            reset();
            shuffle();
        }
        public Deck reset()
        {
            cards = new List<Card>();
            string[] suits = {"hearts","diamonds","spades","clubs"};
            string[] strVals = {"ace","two","three","four","five","six","seven","eight","nine","ten","jack","queen","king"};
            foreach (string suit in suits)
            {
                for(int i=0; i<strVals.Length;i++)
                {
                    Card Ncard = new Card(strVals[i],suit,i+1);
                    cards.Add(Ncard);
                }
            }
            return this;
        }
        public Deck shuffle()
        {
            Random rand = new Random();
            for (int i=0; i<cards.Count; i++)
            {
                int randI=rand.Next(cards.Count);
                Card temp= cards[randI];
                cards[randI]= cards[i];
                cards[i]=temp;
            }
            return this;
        }
        public Card deal()
        {
            if (cards.Count>0)
            {
                Card topCard = cards[0];
                cards.RemoveAt(0);
                return topCard;
            }
            else
            {
                reset();
                return deal();
            }
        }
    
    }

}