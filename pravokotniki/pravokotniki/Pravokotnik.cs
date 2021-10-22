using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravokotniki
{
    class Pravokotnik
    {
        private int širina;
        private int višina;
        public Pravokotnik()
        {
            this.širina = 0;
            this.višina = 0;
        }

        public Pravokotnik(int s, int v)
        {
            this.širina = s;
            this.višina = v;
        }


        public int Širina { get => širina; set => širina = value; }
        public int Višina { get => višina; set => višina = value; }

        public int Ploščina { get => širina*višina; }

        public static bool operator ==(Pravokotnik a, Pravokotnik b)
        {
            return (a.Ploščina == b.Ploščina);
        }

        public static bool operator !=(Pravokotnik a, Pravokotnik b)
        {
            return (a.Ploščina != b.Ploščina);
        }

        public static bool operator >(Pravokotnik a, Pravokotnik b)
        {
            return (a.Ploščina > b.Ploščina);
        }

        public static bool operator >=(Pravokotnik a, Pravokotnik b)
        {
            return (a.Ploščina >= b.Ploščina);
        }

        public static bool operator <(Pravokotnik a, Pravokotnik b)
        {
            return (a.Ploščina < b.Ploščina);
        }

        public static bool operator <=(Pravokotnik a, Pravokotnik b)
        {
            return (a.Ploščina <= b.Ploščina);
        }

        public override string ToString()
        {
            return "Širina: " + širina + " Višina: " + višina + " Ploščina: " + Ploščina; 
        }
    }
}
