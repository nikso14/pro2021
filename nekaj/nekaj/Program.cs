using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nekaj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("clen 2 " + ClenZap(2));
            Console.ReadLine();
        }

        static int ClenZap(int n)
        {
            if(n == 1 ||n == 2)
            {
                return 2;
            }
            return ClenZap(n - 2) * ClenZap(n - 1) - 1;
        }
        
        static int Fib(int n)
        {
            //rekurzivno izrečuna n-to fibonacijevo število
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return (Fib(n-1) + Fib(n - 2));
        }
        

        static int PotencaIterativno(int n)
        {
            int potenca = 1;
            for(int k = 1; k<=n; k++)
            {
                potenca = potenca * 2;
            }
            return potenca;
        }

        static int PotencaRekurzivno(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return 2 * PotencaRekurzivno(n - 1);
        }
    }
}
