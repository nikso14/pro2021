using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsšMobile
{
    class Kupec
    {
        private string ime;
        private decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje; set => stanje = value; } //read only

        public void BeležiKlic(decimal plačano)
        {
            stanje -= plačano;
        }
        public void BeležiKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1: //stacionarno
                    stanje += minute * 0.2m;
                    break;
                case 2://mobilno
                    stanje += minute * 0.03m;
                    break;
            }
        }
    }
}
