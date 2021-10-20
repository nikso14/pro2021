using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsšMobile
{
    class Kupec60: Kupec
    {
        private int višjaTarifaPorabljeno; //koliko od 60 minut je porabil

        public new void BeležiKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1:
                    Stanje += minute * 0.2m;
                    break;
                case 2:
                    //prvih 60 minut po 0.05
                    //ostale 0.01
                    int vMinute, nMinute;
                    int šeVMinute = (višjaTarifaPorabljeno < 60) ? 60 - višjaTarifaPorabljeno : 0;
                    if (minute > šeVMinute)
                    {
                        vMinute = šeVMinute;
                        nMinute = minute - vMinute;
                    }
                    else
                    {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    Stanje += vMinute * 0.5m + nMinute * 0.1m;
                    višjaTarifaPorabljeno += vMinute;
                    break;
            }
        }
    }
}
