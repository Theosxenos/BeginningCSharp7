﻿using System;

namespace Ch12CardLib
{
    public class Deck : ICloneable
    {
        private Cards cards = new Cards();

        public Deck()
        {

            //// Book solution
            //for (int suitVal = 0; suitVal < 4; suitVal++)
            //{
            //    for (int rankVal = 1; rankVal < 14; rankVal++)
            //    {
            //        cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
            //    }
            //}

            // Loop through all the Suit and Rank enum values
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        private Deck(Cards newCards) => cards = newCards;

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high.
        /// </summary>
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        /// <summary>
        /// Nondefault constructor. Allows a trump suit to be used.
        /// </summary>
        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high and a trump suit
        /// to be used.
        /// </summary>
        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);

            return newDeck;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw new ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51.");
        }

        public void Shuffle()
        {
            /// Book solution
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);

        }
    }
}
