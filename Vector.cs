using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Vector
    {
        readonly public double X;
        readonly public double Y;
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Vector Parse(string s)
        {
            string[] componenti = s.Split(';');
            double x = double.Parse(componenti[0]);
            double y = double.Parse(componenti[1]);
            return new Vector(x, y);
        }
        public Vector TryParse(string s)
        {
            string[] componenti = s.Split(';');
            if (double.TryParse(componenti[0], out double x) && double.TryParse(componenti[1], out double y))
            {
                return new Vector(x, y);
            }
            else
            {
                return null;
            }
        }
        public override string ToString()
        {
            return X + "   " + Y;
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
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
        public static Vector operator *(Vector a, Vector b)
        {
            return new Vector(a.X * b.X, a.Y * b.Y);
        }
        public static Vector operator /(Vector a, Vector b)
        {
            return new Vector(a.X / b.X, a.Y / b.Y);
        }
        public static Vector operator *(Vector a, double b)
        {
            return new Vector(a.X * b, a.Y * b);
        }
        public static Vector operator *(double b, Vector a)
        {
            return new Vector(a.X * b, a.Y * b);
        }
        public static Vector operator /(Vector a, double b)
        {
            return new Vector(a.X / b, a.Y / b);
        }
        public static Vector operator -(Vector a)
        {
            return (a * (-1));
        }
        public static Vector operator +(Vector a)
        {
            return (a);
        }
        public double Modulo()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public Vector Versore()
        {
            return this / this.Modulo();
        }

    }
}
