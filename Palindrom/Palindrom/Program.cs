using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JePalindrom("abba"));
            Console.ReadLine();
        }

        static bool JePalindrom(String niz)
        {
            if (niz.Length == 1 || niz.Length == 0)
            {
                return true;
            }
            else if (niz[0] == niz[niz.Length-1])
            {
               return JePalindrom(niz.Substring(1, niz.Length - 2));
            }
            else
            {
                return false;
            }
            
        }
    }
}
