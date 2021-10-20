using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    abstract class Mutant : IPrikazovalnik
    {
        public string Ime { get; set; }
        public int Stopnja { get; set; }
        public abstract int KvocientNevarnosti();
        public void PrikažiInformacije()
        {
            Console.WriteLine("**************mutant*************");
            Console.WriteLine(Ime);
            Console.WriteLine("kvocient nevarnosti " + KvocientNevarnosti());
        }
    }
}
