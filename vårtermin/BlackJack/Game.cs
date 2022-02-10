using System;

namespace BlackJack
{
    public enum GameStatus
    {
        Won, Lost, Playing, Tie, BlackJack
    }
    public class Game
    {
        public Player Player { get; set; }
        public Player Dealer { get; set; }
        public Deck Deck { get; set; }
        public GameStatus Status { get; set; }

        public Game()
        {

        }

        public string GameToString()
        {
            return "";
        }

        public void PlayerDraw()
        {

        }
        public void DealerDraw()
        {

        }
    }
}