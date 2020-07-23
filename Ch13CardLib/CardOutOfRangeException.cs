using System;

namespace Ch13CardLib
{
    public class CardOutOfRangeException : Exception
    {
        public Cards DeckContents { get; }

        /// <summary>
        /// Constructor for the costum exception. Raises the base constructor with a default error message
        /// </summary>
        /// <param name="sourceDeckContents">Contents of the deck that raised the error</param>
        public CardOutOfRangeException(Cards sourceDeckContents) : base("There are only 52 cards in the deck.")
        {
            DeckContents = sourceDeckContents;
        }
    }
}
