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
            public double this[int i]
            {
                get
                {
                    switch (i)
                    {
                        case 0:
                            return x;
                        case 1:
                            return y;
                        case 2:
                            return z;
                        default:
                            throw new IndexOutOfRangeException("Napačen indeks");
                    }
                }
                set
                {
                    switch (i)
                    {
                        case 0:
                            x = value; break;
                        case 1:
                            y = value; break;
                        case 2:
                            z = value; break;
                        default:
                            throw new IndexOutOfRangeException("napačen indeks");
                    }
                }
            }
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


            //z indeksiranjem
            for (int k = 0; k < 3; k++)
                v1[k] = 2 * k;
            Console.WriteLine(v1.ToString());
            Console.ReadLine();
        }
    }
}
