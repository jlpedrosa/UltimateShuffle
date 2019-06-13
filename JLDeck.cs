using System;
using System.Collections.Generic;
using System.Linq;


namespace AndyCards
{

    public class JLDeck : IDeck
    {
        private const byte ncards = 52;
        private readonly byte [] FreshDesk = Enumerable.Range(0, ncards).Select(x=> (byte) x).ToArray();
        private readonly Card [] dealtCards = Enumerable.Range(0, ncards).Select(x => new Card { Val = x, Drawn = true }).ToArray();

        private byte[] cards;
        private Random r;
        private byte count;

        public JLDeck()
        {
            cards = Enumerable.ToArray(FreshDesk);
            r = new Random();
            count = ncards;
        }
       

        public Card Pop() => count == 0 ? null : dealtCards[cards.FastRemoveAt(r.Next(0, count), count--)];
        public void Cut(int number) => r.Next();

        public IEnumerable<Card> ReturnDeck()
        {
            for (int i = ncards - 1; i > count - 1; i--)
            {
                yield return new Card() { Val = cards[i], Drawn = true };
            }

            Card c;
            while ((c = this.Pop()) != null)
            {
                c.Drawn = false;
                yield return c;
            }
        }
    }

}
