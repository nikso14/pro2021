using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsšMobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.BeležiKlic(10, 1);
            Console.WriteLine(janez.Ime + " dolguje " + janez.Stanje);
            Kupec alenka = new Kupec60();
            alenka.Ime = "Alenka Prinčič";
            alenka.BeležiKlic(70, 2);
            Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje);
            
            
            
            Console.ReadLine();
        }
    }
}
