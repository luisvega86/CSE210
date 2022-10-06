using System;


namespace Unit02.HiLo
{
    /// <summary>
    /// This class generates / draws a new Card with a value between 1-13.
    /// </summary> 
    public class Card
    {
        public int cardValue = 0;
        

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Generates a new random value for a card value.
        /// </summary>
        public void getNewCard()
        {
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1, 14);
        }

    }
}