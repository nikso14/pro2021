using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture
{
    class Program
    {
        struct Vektor
        {
            public double x, y, z;
        }
       
        static void Main(string[] args)
        {
            Vektor v1; //deklaracije
            v1.x = 1;
            v1.y = 1;
            v1.z = 1;

            Vektor v2 = new Vektor();
            v2.x = 2;
            v2.y = -1;
            v2.z = 1;
        }
    }
}
