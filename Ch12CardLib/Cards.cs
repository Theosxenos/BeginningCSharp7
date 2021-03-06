﻿using System;
using System.Collections.Generic;

namespace Ch12CardLib
{
    class Cards : List<Card>, ICloneable
    {
        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Clone current object into a new one
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Cards newCards = new Cards();

            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }

            return newCards;
        }
    }
}
