
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AndyCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Bench("JL", (i) => new JLDeck());
            Bench("Andy", (i) => new AndyDeck());
        }

        static  void Bench(string code, Func<int, IDeck> creationFunc)
        {
            List<IDeck> decks = Enumerable.Range(0, 100000).Select(x => creationFunc(x)).ToList();
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (var deck in decks)
            {
                deck.Cut(34);
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();
                deck.Pop();

            }

            Console.WriteLine($"{code} took {stopwatch.ElapsedMilliseconds} ms");

        }
    }
}
