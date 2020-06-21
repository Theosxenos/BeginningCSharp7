using System;

namespace Ch11CardLib
{
    public class Card : ICloneable
    {

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;
        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Club;
        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        /// <summary>
        /// Rank of the card
        /// </summary>
        public Rank rank;
        /// <summary>
        /// Suit of the card
        /// </summary>
        public Suit suit;

        private Card() { }

        /// <summary>
        /// The public constructor for making a new card object
        /// </summary>
        /// <param name="newSuit">The suit of the new card</param>
        /// <param name="newRank">The rank of the new card</param>
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        /// <summary>
        /// Overloads the ToString method to return the card info
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"The {rank} of {suit}s";

        public object Clone()
        {
            return MemberwiseClone();
        }

        public static bool operator ==(Card card1, Card card2) => (card1?.suit == card2?.suit) && (card1?.rank == card2?.rank);
        public static bool operator !=(Card card1, Card card2) => !(card1 == card2);
        public override bool Equals(object card) => this == (Card)card;
        public override int GetHashCode() => 13 * (int)suit + (int)rank;
        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2?.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                return true;
            }
        }
        public static bool operator <(Card card1, Card card2) => !(card1 >= card2);
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        public static bool operator <=(Card card1, Card card2) => !(card1 > card2);
    }
}