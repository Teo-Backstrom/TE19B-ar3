using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public Card LastDrawnCard { get; set; }
        public int LowValue { get; set; }
        public int HighValue { get; set; }
        public int BestValue { get; set; }

        public void Reset()
        {

        }
        public string PlayerToString()
        {
            return "";
        }
    }
}