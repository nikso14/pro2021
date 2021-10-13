using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortiranje
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = 50000;
            int[] a = new int [n];
            Random r = new Random();
            for(int k = 0; k<n; k++)
            {
                a[k] = r.Next(n);
            }
            DateTime d = DateTime.Now;
            Vstavljanje(a);
            DateTime d1 = DateTime.Now;
            TimeSpan ts = d1 - d;
            Console.WriteLine("čas za vstavljanje je " + ts.TotalMilliseconds + " ms");
            for (int k = 0; k < n; k++)
            {
                a[k] = r.Next(n);
            }
            d = DateTime.Now;
            Izbiranje(a);
            d1 = DateTime.Now;
            ts = d1 - d;
            Console.WriteLine("čas za izbiranje je " + ts.TotalMilliseconds + " ms");
            */


            /*
            double[] a = { 0.2, 1.2, 3.5, 2.5, 1.5 };
            Console.WriteLine("neurejena");
            IzpisD(a);
            QuickSortD(0, a.Length - 1, a);
            Console.WriteLine("urejena");
            IzpisD(a);
            Console.ReadLine();
            */

            String[] a = { "aa", "ba", "bb" , "ab" };
            Console.WriteLine("neurejena");
            IzpisS(a);
            QuickSortS(0, a.Length - 1, a);
            Console.WriteLine("urejena");
            IzpisS(a);
            Console.ReadLine();
        }
        static void Izbiranje(int [] a)
        {
            for (int k = 0; k<a.Length - 1; k++)
            {
                //poišči minimum
                int min = a[k];
                int minIndeks = k;
                for(int j = k; j < a.Length; j++)
                {
                    if(a[j] < min)
                    {
                        min = a[j];
                        minIndeks = j;
                    }
                }
                //zamenjaj k-ti in najmanjši element
                int temp = a[k];
                a[k] = min;
                a[minIndeks] = temp;
                

            }
        }
        static void Vstavljanje(int [] a)
        {
            for(int k = 1; k < a.Length; k++)
            {
                int j = k;
                int temp = a[k];
                while(j > 0 && a[j - 1] > temp)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = temp;
                
            }
        }
        static void Izpis(int [] a)
        {
            for(int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + "\t");
            }
            Console.WriteLine();
        }

        static void IzpisD(double[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + "\t");
            }
            Console.WriteLine();
        }

        static void IzpisS(String[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + "\t");
            }
            Console.WriteLine();
        }


        static int Pivot(int zač, int konec, int[] tab)
        {
            int p = tab[zač];
            int m = zač;
            int n = konec + 1;
            // poišči z m prvega ki, je večji od p
            do 
            { m = m + 1; } while(tab[m] <= p & m < konec);
            do
            { n = n - 1; } while (tab[n] > p);
            //tab[m] je večji od p
            //tab[n] je manjši od p
            //zamenjaj jih
            
            while(m < n)
            {
                int temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                { m = m + 1; } while (tab[m] <= p);
                do
                { n = n - 1; } while (tab[n] > p);
            }
            //zamenjaj pivotni element
            int temp2 = tab[n];
            tab[n] = tab[zač];
            tab[zač] = temp2;
            return n;
        }

        static int PivotD(int zač, int konec, double[] tab)
        {
            double p = tab[zač];
            int m = zač;
            int n = konec + 1;
            // poišči z m prvega ki, je večji od p
            do
            { m = m + 1; } while (tab[m] <= p & m < konec);
            do
            { n = n - 1; } while (tab[n] > p);
            //tab[m] je večji od p
            //tab[n] je manjši od p
            //zamenjaj jih

            while (m < n)
            {
                double temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                { m = m + 1; } while (tab[m] <= p);
                do
                { n = n - 1; } while (tab[n] > p);
            }
            //zamenjaj pivotni element
            double temp2 = tab[n];
            tab[n] = tab[zač];
            tab[zač] = temp2;
            return n;
        }

        static int PivotS(int zač, int konec, String[] tab)
        {
            String p = tab[zač];
            int m = zač;
            int n = konec + 1;
            // poišči z m prvega ki, je večji od p
            do
            { m = m + 1; } while (tab[m].CompareTo(p) < 0 & m < konec);
            do
            { n = n - 1; } while (tab[n].CompareTo(p) > 0);
            //tab[m] je večji od p
            //tab[n] je manjši od p
            //zamenjaj jih

            while (m < n)
            {
                String temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                { m = m + 1; } while (tab[m].CompareTo(p) < 0);
                do
                { n = n - 1; } while (tab[n].CompareTo(p) > 0);
            }
            //zamenjaj pivotni element
            String temp2 = tab[n];
            tab[n] = tab[zač];
            tab[zač] = temp2;
            return n;
        }

        static void QuickSort(int zač, int konec, int[] tab)
        {
            if(zač >= konec)
            {
                return;
            }
            int a = Pivot(zač, konec, tab);
            QuickSort(zač, a - 1, tab);//levi del
            QuickSort(a + 1, konec, tab);//desni del
        }

        static void QuickSortD(int zač, int konec, double[] tab)
        {
            if (zač >= konec)
            {
                return;
            }
            int a = PivotD(zač, konec, tab);
            QuickSortD(zač, a - 1, tab);//levi del
            QuickSortD(a + 1, konec, tab);//desni del
        }
        static void QuickSortS(int zač, int konec, String[] tab)
        {
            if (zač >= konec)
            {
                return;
            }
            int a = PivotS(zač, konec, tab);
            QuickSortS(zač, a - 1, tab);//levi del
            QuickSortS(a + 1, konec, tab);//desni del
        }

    }
}
