using System;

namespace HanojskiStolpi
{
    class Program
    {
        static void Main(string[] args)
        {
            Premakni(3, "a", "c", "b");
            Console.WriteLine();
        }

        static void Premakni(int n, string začetni, string končni, string pomožni)
        {
            if(n == 1)
            {
                Console.WriteLine("premakni iz " + začetni + " na " + končni);
                return;
            }
            Premakni(n - 1, začetni, pomožni, končni);
            Console.WriteLine("Premakni iz " + začetni + " na " + končni);
            Premakni(n - 1, pomožni, končni, začetni);
        }
       
    }
}
