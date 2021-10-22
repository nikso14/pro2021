using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računanje
{
    class Kompleksno
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public override string ToString()
        {
            return Re + " + i * " + Im; 
        }


        public static Kompleksno operator +(Kompleksno a, Kompleksno b)
        {
            Kompleksno c = new Kompleksno();
            c.Re = a.Re + b.Re;
            c.Im = a.Im + b.Im;
            return c;
        }

        public static Kompleksno operator -(Kompleksno a, Kompleksno b)
        {
            Kompleksno c = new Kompleksno();
            c.Re = a.Re - b.Re;
            c.Im = a.Im - b.Im;
            return c;
        }

        public static Kompleksno operator *(Kompleksno a, Kompleksno b)
        {
            Kompleksno c = new Kompleksno();
            c.Re = a.Re * b.Re - a.Im * b.Im;
            c.Im = a.Re * b.Im + a.Im * b.Re;
            return c;
        }
    }

}
