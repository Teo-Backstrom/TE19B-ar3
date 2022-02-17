using System;

namespace Labb18
{
    public class Knight : Creature
    {
        protected string Weapon { get; set; }

        public Knight(string n, string weapon) : base(n)
        {
            Weapon = weapon;
        }

        public void Attack()
        {

        }
    }
}