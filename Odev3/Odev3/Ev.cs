using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    public class Ev
    {
        public void Baba(/*string meslek,int yas, string isim*/)
        {
            string meslek, isim;
            int yas;
            Console.WriteLine("Babanızın ismini giriniz");
            isim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Babanızın mesleğini giriniz");
            meslek = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Babanızın yaşını giriniz");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Babanızın adı: {0} \t Babanızın yaşı: {1} \t Babanızın mesleği: {2} ", isim, yas, meslek);


        }

        public void Anne(/*string meslek,int yas, string isim*/)
        {
            string meslek, isim;
            int yas;
            Console.WriteLine("Annenizin ismini giriniz");
            isim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Annenizin mesleğini giriniz");
            meslek = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Annenizin yaşını giriniz");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annenizin adı: {0} \t Annenizin yaşı: {1} \t Annenizin mesleği: {2} ", isim, yas, meslek);


        }
    }
}
