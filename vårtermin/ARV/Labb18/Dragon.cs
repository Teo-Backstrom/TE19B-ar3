using System;

namespace Labb18
{
    public class Dragon : Creature
    {
        protected string Color { get; set; }

        public Dragon(string n, string color) : base(n)
        {

            Color = color;

        }
        public void Attack()
        {

        }
    }
}