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
    }
}
