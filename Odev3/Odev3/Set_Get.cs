using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class Set_Get
    {
        int Sayi;
        public int SahteOzellik
        {
            set
            {
                if (value < 0) Sayi = 0;
                else Sayi = value;
            }
            get
            {
                if (Sayi > 100) return Sayi / 100;
                else return Sayi;
            }
        }
    }
}
