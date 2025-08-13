<<<<<<< HEAD
﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

           BlackJackDeck deck = new BlackJackDeck();
          
            var hand = deck.DealCards();

            foreach(var card in hand)
            {
                Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()} ");
            }



            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        // protected allow access to the derived classes

        // creating the  deck then populate it with cards 
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();

        // put out when deal and request cards
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();

        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();


        // populate a full deck of cards
        protected void CreateDeck()
        {
            fullDeck.Clear(); // clear the deck before creating a new one


            // loop[ throught suits
            for (int suit = 0; suit < 4; suit++)
            {
                // loop through values
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardModel()
                    {
                        Suit = (CardSuit)suit,
                        Value = (CardValue)val
                    });
                }
            }

        }

        // shuffle the deck - might shuffle deck differently
        public virtual void ShuffleDeck()
        {
            
            var rand = new Random();
            // orderBy sorts the list
            drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
        }

        // depending on the game, deal a certain number of cards
        public abstract List<PlayingCardModel> DealCards();

        // request one card from the list
        protected virtual  PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    
    }

    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            // create & shuffle the deck when first come to the application
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            // get five cards from the deck
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            // add one card to the output list then take out a card and add it to the discard pile
            foreach (var card in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }
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
=======
﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

           BlackJackDeck deck = new BlackJackDeck();
          
            var hand = deck.DealCards();

            foreach(var card in hand)
            {
                Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()} ");
            }



            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        // protected allow access to the derived classes

        // creating the  deck then populate it with cards 
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();

        // put out when deal and request cards
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();

        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();


        // populate a full deck of cards
        protected void CreateDeck()
        {
            fullDeck.Clear(); // clear the deck before creating a new one


            // loop[ throught suits
            for (int suit = 0; suit < 4; suit++)
            {
                // loop through values
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardModel()
                    {
                        Suit = (CardSuit)suit,
                        Value = (CardValue)val
                    });
                }
            }

        }

        // shuffle the deck - might shuffle deck differently
        public virtual void ShuffleDeck()
        {
            
            var rand = new Random();
            // orderBy sorts the list
            drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
        }

        // depending on the game, deal a certain number of cards
        public abstract List<PlayingCardModel> DealCards();

        // request one card from the list
        protected virtual  PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    
    }

    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            // create & shuffle the deck when first come to the application
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            // get five cards from the deck
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            // add one card to the output list then take out a card and add it to the discard pile
            foreach (var card in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }
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
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
