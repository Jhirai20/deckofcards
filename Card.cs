using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Card
    {
        public string StrVal; //ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King).
        public string Suit;// (Clubs, Spades, Hearts, Diamonds).
        public int Value;//  1-13 
        public Card(string strVal, string suit, int value )
        {
            StrVal=strVal;
            Suit=suit;
            Value=value;
        }
    }
}