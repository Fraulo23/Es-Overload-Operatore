using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(15, 10);
            Vector v2=new Vector(30, 10);
            /*Console.WriteLine(v1+v2);
            Console.WriteLine(v1-v2);
            Console.WriteLine(v1*v2);
            Console.WriteLine(v1/v2);
            float s = 5;
            Console.WriteLine(v1*s);
            Console.WriteLine(s*v1);
            Console.WriteLine(v1/s);
            Console.WriteLine(+v1);
            Console.WriteLine(-v1);*/
            Console.WriteLine(v1.Versore());
            Console.WriteLine(v1.Modulo());
            Console.ReadLine();
        }
    }
}
