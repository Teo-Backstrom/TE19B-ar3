using System;

namespace Labb18
{
    public class Creature
    {
        public int Health { get; set; }
        public int Shield { get; set; }

        protected string Name { get; set; }

        public Creature(string name)
        {

        }

        public string GetInfo()
        {
            return null;
        }
    }
}