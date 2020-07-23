using Ch13CardLib;
using static System.Console;

namespace Ch13CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();

            try
            {
                Card myCard = deck1.GetCard(60);
            }
            catch (CardOutOfRangeException e)
            {
                WriteLine(e.Message);
                WriteLine(e.DeckContents[0]);                
            }
        }
    }
}
