﻿// DeckOfCardsTest.cs
// Card shuffling and dealing application.
using System;

namespace Lab3Problem1
{
    public class DeckOfCardsTest
    {
        // execute application
        public static void Main(string[] args)
        {
            DeckOfCards myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle(); // place Cards in random order

            int count = 0;
            do
            {
                Console.WriteLine();
                myDeckOfCards.EvaluateHand();
                Console.WriteLine(myDeckOfCards.PrintHand());
                Console.WriteLine("Evalute hand...");

                count += 5;
                Console.WriteLine($"Has 2 faces:{myDeckOfCards.HasNFaces(2)}");
                Console.WriteLine($"Has 2 suits:{myDeckOfCards.HasNSuits(2)}");
            } while (count < 55);

            //// display all 52 Cards in the order in which they are dealt
            //for (int i = 0; i < 52; i++)
            //{
            //    Console.Write("{0,-19}", myDeckOfCards.DealCard());

            //    if ((i + 1) % 4 == 0)
            //        Console.WriteLine();
            //} // end for
        } // end Main
    } // end class DeckOfCardsTest
}

