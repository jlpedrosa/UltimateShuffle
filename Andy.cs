using System;
using System.Collections.Generic;
using System.Linq;

namespace AndyCards
{

    public class AndyDeck : IDeck
    {
        private List<int> cards = Enumerable.Range(0, 52).ToList();
        private Random r = new Random();
        private short count = 52;

        public Card Pop()
        {
            return count == 0 ? null : new Card() { Val = cards.FastRemoveAt(r.Next(0, count), count--), Drawn = true };
        }

        public void Cut(int number) { r.Next(); }

        public IEnumerable<Card> ReturnDeck()
        {
            for (int i = 51; i > count - 1; i--)
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


