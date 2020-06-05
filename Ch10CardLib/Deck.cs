using System;
using System.Linq;

namespace Ch10CardLib
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];

            // Book solution
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }

            //// Loop through all the Suit and Rank enum values
            //foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            //{
            //    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            //    {
            //        // The length of the array should give the last non used index to make a new card in
            //        cards[cards.Length] = new Card(suit, rank);
            //    }
            //}
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
            Card[] newDeck = new Card[52];
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(52);
                    if (assigned[destCard] == false)
                        foundCard = true;
                }
                assigned[destCard] = true;
                newDeck[destCard] = cards[i];
            }
            newDeck.CopyTo(cards, 0);

        }
    }
}
