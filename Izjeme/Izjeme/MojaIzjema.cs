﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    class MojaIzjema:ApplicationException
    {

        public MojaIzjema():
            base("sprožila se je moja izjema")
        {

        }

        public MojaIzjema(String sp):
            base("Sprožila se je moja izjema" + sp)
        {

        }
    }
}
