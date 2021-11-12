using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace računanje_kvadratnega_korena
{
    class NegativnoException: ApplicationException
    {
        public NegativnoException() : base("ni dovoljeno računanje korena negativnih števil")
        {

        }
    }
}
