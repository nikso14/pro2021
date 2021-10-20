using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    class Psiho : Mutant
    {
        public int IQ { set; get; }
        public int ŠteviloUporabeMoči { set; get; }
        public override int KvocientNevarnosti()
        {
            return Stopnja * IQ * ŠteviloUporabeMoči;
        }
    }
}
