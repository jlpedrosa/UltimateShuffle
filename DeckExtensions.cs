using System.Collections.Generic;

namespace AndyCards
{
    public static class DeckExtensions
    {
        public static T FastRemoveAt<T>(this List<T> cards, int index, short count)
        {
            T c = cards[index];
            cards[index] = cards[count - 1];
            cards[count - 1] = c;
            return c;
        }

        public static T FastRemoveAt<T>(this T[] cards, int index, short count)
        {
            T c = cards[index];
            cards[index] = cards[count - 1];
            cards[count - 1] = c;
            return c;
        }
    }

}