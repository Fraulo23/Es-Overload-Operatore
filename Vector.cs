﻿using System;
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
        public static bool operator ==(Vector f, Vector f2)
        {
            if (object.ReferenceEquals(f, null))
                return object.ReferenceEquals(f2, null);
            else if (object.ReferenceEquals(f2, null))
                return false;
            else
                return f.X == f2.X && f.Y == f2.Y;
        }
        public static bool operator !=(Vector f, Vector f2)
        {
            return !(f == f2);
        }
        public static bool operator >(Vector f, Vector f2)
        {
            return f.Modulo() > f2.Modulo();
        }
        public static bool operator <(Vector f, Vector f2)
        {
            return f.Modulo() < f2.Modulo();
        }
        public static bool operator >=(Vector f, Vector f2)
        {
            return f.Modulo() >= f2.Modulo();
        }
        public static bool operator <=(Vector f, Vector f2)
        {
            return f.Modulo() <= f2.Modulo();
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
        public static Vector operator *(Vector a, float b)
        {
            return new Vector(a.X * b, a.Y * b);
        }
        public static Vector operator *(float b, Vector a)
        {
            return new Vector(a.X * b, a.Y * b);
        }
        public static Vector operator /(Vector a, float b)
        {
            return new Vector(a.X / b, a.Y / b);
        }
        public static Vector operator -(Vector a)
        {
            return (a*(-1));
        }
        public static Vector operator +(Vector a)
        {
            return (a);
        }
        public double Modulo()
        {
            return Math.Sqrt(X*X+Y*Y);
        }
        public Vector ValoreAssoluto()
        {
            if (this.Modulo() < 0)
            {
                return this * (-1);
            }
            else
            {
                return this;
            }
        }
        public Vector Versore()
        {
            return this/this.ValoreAssoluto();
        }

    }
}
