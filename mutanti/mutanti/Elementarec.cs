using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Elementarec : Mutant
    {
        public int Področje { set; get; }
        public override int KvocientNevarnosti()
        {
            return Področje * Stopnja;
        }
    }
}
