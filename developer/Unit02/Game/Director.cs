using System;
using System.Collections.Generic;


namespace Unit02.HiLo
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int guessRight = 100;
        int guessWrong = 75;
        int lifeScore = 300;

        int currentCard;
        int nextCard;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
            
            
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            foreach (Card card in cards)
            {
                card.getNewCard();
                currentCard = card.cardValue;
            }

            while (isPlaying)
            {
                gameMain();
                gameResume();
            }
        }

        public void gameMain()
        {
            Console.WriteLine($"The card is {currentCard}");
            if (!isPlaying)
            {
                return;
            }
            // draw a new card
            foreach (Card card in cards)
            {
                card.getNewCard();
                nextCard = card.cardValue;
            }
            // Ask the user for a guess and store it in a variable to calculate the result
            Console.Write("Higher or Lower? [h/l]: ");
            string cardGuess = Console.ReadLine();
            Console.WriteLine($"The next card was:{nextCard}");

            
            // Possible outcomes
            if (cardGuess == "h" && currentCard < nextCard)
            {
                lifeScore += guessRight;
            }

            else if (cardGuess == "h" && currentCard > nextCard)
            {
                lifeScore -= guessWrong;
                if (lifeScore < 0)
                {
                    lifeScore = 0;
                }
            }

            if (cardGuess == "l" && currentCard > nextCard)
            {
                lifeScore += guessRight;
            }

            else if (cardGuess == "l" && currentCard < nextCard)
            {
                lifeScore -= guessWrong;
                if (lifeScore < 0)
                {
                    lifeScore = 0;
                }
            }


        }

        public void gameResume()
        {
            Console.WriteLine($"Your score is {lifeScore}");
            if (lifeScore == 0)
            {
                isPlaying = false;
                Console.WriteLine("Game Over");
            }

            if (!isPlaying)
            {
                return;
            }

            currentCard = nextCard;
            Console.Write("Play again? [y/n]: ");
            string keepPlaying = Console.ReadLine();
            isPlaying = (keepPlaying == "y");
        }
    }
}


