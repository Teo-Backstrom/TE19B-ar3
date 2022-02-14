using System;
using System.Numerics;

namespace Uppgift_2
{
    public class GameObject
    {
        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public float Rotation { get; set; }

        public bool CollidesWith(IGameObject other)
        {
            return false;
        }


    }

    public interface IGameObject
    {
    }
}