using static System.Console;
using Ch10CardLib;
using System.Collections.Generic;

namespace Exer10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init new deck
            Deck myDeck = new Deck();
            
            // Shuffle deck
            myDeck.Shuffle();

            // Iterate through the deck, every 5th card
            for (int i = 0; i < 46; i += 5)
            {
                // bool to keep a check if suits match
                bool sameSuit = false;
                // List to hold the cards that match
                List<Card> matchingCards = new List<Card>();

                // Iterate through the deck starting from the current 5th until the one before the next 5th
                for (int j = i; j <= i + 3; j++)
                {
                    // Get the current card and next card
                    var curCard = myDeck.GetCard(j);
                    var nextCard = myDeck.GetCard(j + 1);

                    // Add the current card to the matchlist
                    matchingCards.Add(curCard);

                    // Check if the cards match
                    if (curCard.suit == nextCard.suit)
                    {
                        // if match then set the bool
                        sameSuit = true;

                        // Because last card isn't compared (due to 5 card limit), we need to add the last card manually during the last iteration
                        if (j == i + 3)
                        {
                            matchingCards.Add(nextCard);
                        }
                    }
                    else
                    {
                        // If it doesn't match set bool to false and break the loop, because we need to have all 5 matching
                        sameSuit = false;
                        break;
                    }
                }

                // If all 5 match
                if (sameSuit)
                {
                    WriteLine("Flush!");
                    WriteLine("With the following cards:");

                    foreach (var card in matchingCards)
                    {
                        WriteLine($"  - {card.ToString()}");
                    }

                    // Exit the method
                    return;
                }
            }

            // If no cards match
            WriteLine("No Flush");
        }
    }
}
