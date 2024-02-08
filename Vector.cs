using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Vector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return X+";"+Y;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X+b.X, a.Y+b.Y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X-b.X, a.Y-b.Y);
        }
        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.X*b.X, a.Y*b.Y);
        }
        public static Vector operator /(Vector a, Vector b)
        {
            return new Vector(a.X / b.X, a.Y / b.Y);
        }
    }
}
