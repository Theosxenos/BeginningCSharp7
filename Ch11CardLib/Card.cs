﻿using System;

namespace Ch11CardLib
{
    public class Card : ICloneable
    {
        public Rank rank;
        public Suit suit;

        private Card() { }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString() => $"The {rank} of {suit}s";

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}