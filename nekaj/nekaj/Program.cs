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
            Console.WriteLine(ClenZap(3));
            Console.WriteLine(nal_4(3));
            Console.WriteLine(nal_5(3));
            Console.WriteLine(nal_6(3));
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
        
        static int nal_4(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            return 3 * nal_4(n - 1) + 2;
        }

        static int nal_5(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if(n == 2)
            {
                return 2;
            }
            return nal_5(n - 1) * 2 + nal_5(n - 2);
        }

        static int nal_6(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if(n == 2)
            {
                return 4;
            }
            return nal_6(n - 1) + 2;
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
