using BlackJackLibrary.Enums;
using BlackJackLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlackJackUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BlackJackDeck deck = new BlackJackDeck();

            var dealerHand = deck.DealCards();
            int dealerTotalHand = 0;


            Console.WriteLine($"Dealer hand: {dealerHand[1].Value.ToString()} ");
            for (int i = 0; i < 2; i++)
            {
                int cardValue = (int)dealerHand[i].Value; 
                // only show the user the second card in hand
                if (dealerHand.Count == 2 && dealerHand[i].Value == CardValue.Ace)
                {
                    cardValue = 11;  // treat Ace as 11 instead of 1
                }
                dealerTotalHand += cardValue;

            }
    
            //Console.WriteLine($"Dealer total hand: {dealerTotalHand}");

            Console.WriteLine();

            var userHand = deck.DealCards();
            int totalHand = 0; 

          
            foreach (var card in userHand)
            {

                int cardValue = (int)card.Value;

                Console.WriteLine($"Your hand: {card.Value.ToString()}");

                if(userHand.Count == 2 && card.Value == CardValue.Ace)
                {
                    cardValue = 11;
                }
                totalHand += cardValue;
            }
            Console.WriteLine($"Your total hand: {totalHand}");


          

            // Hit,Stand, Spilt
            Console.Write("Do you want to 'Hit' or 'Stand': ");
            string choice = Console.ReadLine().ToLower();

            

            while (choice != "hit" && choice != "stand")
            {
                Console.WriteLine("Invalid input. Please type 'Hit' or 'Stand'.");
                choice = Console.ReadLine().ToLower();
            }

            bool playerDone = false;

            while (!playerDone)
            {
                if (choice == "hit")
                {
                    var newCard = deck.RequestCard();
                    Console.WriteLine($"You drew {newCard.Value.ToString()}");

                    int cardValue = (int)newCard.Value;
                    if (newCard.Value == CardValue.Ace && totalHand + 11 <= 21)
                    {
                        cardValue = 11;
                    }

                    userHand.Add(newCard);
                    totalHand += cardValue;

                    Console.WriteLine($"New total hand: {totalHand}");
                    if (totalHand > 21)
                    {
                        Console.WriteLine("You Bust!");
                        Console.WriteLine($"Dealer Wins! Dealer Total: {dealerTotalHand}");
                        playerDone = true;
                    }
                    else if (totalHand == 21)
                    {
                        Console.WriteLine("Blackjack! You Win!");
                        Console.WriteLine($"Dealer Total: {dealerTotalHand}");
                        playerDone = true;
                    }
                    else
                    {
                        Console.Write("Do you want to 'Hit' or 'Stand'?: ");
                        choice = Console.ReadLine().ToLower();

                        while (choice != "hit" && choice != "stand")
                        {
                            Console.WriteLine("Invalid input. Please type 'Hit' or 'Stand'.");
                            choice = Console.ReadLine().ToLower();
                        }

                        if (choice == "stand")
                        {
                            playerDone = true;
                        }
                    }

                }
                else if (choice == "stand")
                {
                    playerDone = true;
               
          
                if (totalHand <= 21)
                {
                    while (dealerTotalHand < 17)
                    {
                        var dealerCard = deck.RequestCard();
                        Console.WriteLine($"Dealer drew {dealerCard.Value.ToString()}");
                        dealerHand.Add(dealerCard);

                        int dealerCardValue = (int)dealerCard.Value;
                        if (dealerCard.Value == CardValue.Ace && dealerTotalHand + 11 <= 21)
                        {
                            dealerCardValue = 11;
                        }
                        dealerTotalHand += dealerCardValue;
                        Console.WriteLine($"Final Dealer Hand: {dealerTotalHand}");

                        if (dealerTotalHand > 21 || totalHand > dealerTotalHand)
                        {
                            Console.WriteLine("You Win!");
                        }
                        else if (dealerTotalHand == totalHand)
                        {
                            Console.WriteLine("Push!");
                        }
                        else
                        {
                            Console.WriteLine("Dealer Wins!");
                        }
                    }
                }
            }

                Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();

        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();

        protected void CreateDeck()
        {
            fullDeck.Clear();
            for(int suit = 0 ; suit < 4; suit++)
            {
                for(int val = 1; val < 10; val++)
                {
                    fullDeck.Add(new PlayingCardModel()
                    {
                        Suit = (CardSuit)suit,
                        Value = (CardValue)val

                    });
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rand = new Random();
            drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
        }

        public abstract List<PlayingCardModel> DealCards();

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    }

    public class BlackJackDeck : Deck
    {
        public BlackJackDeck()
        {
            CreateDeck();
            ShuffleDeck(); 
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for(int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());   
            }

            return output;
        }

        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }
    }
}
