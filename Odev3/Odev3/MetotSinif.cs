using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class MetotSinif
    {
        int Sayi;
        public void SayiBelirle(int sayi)
        {
            if (sayi < 0) Sayi = 0;
            else Sayi = sayi;
        }
        public int SayiyiAl()
        {
            if (Sayi > 100)
                return Sayi / 100;
            else
                return Sayi;
        }
    }
}
