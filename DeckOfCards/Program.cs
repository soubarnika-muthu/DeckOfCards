using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation  of Deck of Cards Program");
            Console.WriteLine("Welcome to Deck of Cards");
            //creating object for deck of card class
            DeckOfCards deckOfCards = new DeckOfCards();
            //initialize the player array with 4 players and each player with 9 cards
            Cards[,] players = new Cards[4, 9];
            //call the alotCards method
            players = deckOfCards.alotCards(players);
            deckOfCards.display(players);
            Console.Read();
        }
    }
}
