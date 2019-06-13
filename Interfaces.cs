
using System.Collections.Generic;

namespace AndyCards
{

    public enum Suit { Hearts, Diamonds, Spades, Clubs };
    public enum Rank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    public class Card
    {
        public int Val;
        public Suit Suit { get { return (Suit)(Val / 13); } }
        public Rank Rank { get { return (Rank)(Val % 13); } }
        public bool Drawn { get; set; }
    }

    public interface IDeck
    {
        void Cut(int number);
        Card Pop();
        IEnumerable<Card> ReturnDeck();
    }

}