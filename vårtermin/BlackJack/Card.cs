using System;

namespace BlackJack
{
    public enum SuitType
    {
        Club, Diamond, Heart, Spade
    }
    public class Card
    {

        Random tarning = new Random();
        //Skapa konstruktor och lägg 
        public int Value = tarning.Next(1, 14);
        public SuitType suit { get; set; }
        public int BlackJackValue { get; set; }

        public Card(int value, SuitType suit)
        {

        }

        public string CardsToString()
        {
            return suit + Value.ToString() + "Total: " + BlackJackValue.ToString();
        }

    }
}