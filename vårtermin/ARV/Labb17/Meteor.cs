using System;
using System.Collections.Generic;

namespace Uppgift_2
{
    public class Meteor : GameObject
    {
        public MeteorType Type { get; set; }
        public float ExplosionScale { get; set; }
        public void Meter(MeteorType type)
        {

        }

        public void Update(GameTime gametime)
        {

        }
        public IEnumerable<Meteor> BreakMeteor(Meteor meteor)
        {
            return null;
        }
    }

    public class GameTime
    {
    }

    public class MeteorType
    {
    }
}