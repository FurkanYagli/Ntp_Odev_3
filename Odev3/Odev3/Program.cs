using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Odev3
{

    class A
    {
        public void Metot1()
        { Metot2(); }
        public void Metot2()
        { Console.WriteLine("A sınıfı"); }
    }
    class B : A
    {
        public new void Metot2()
        { Console.WriteLine("B sınıfı"); }
    }

    class Dortgen
    {
        public int En;
        public int Boy;
        public int Alan()
        {
            int Alan = En * Boy; return Alan;
        }
        public void EnBoyBelirle(int en, int boy)
        {
            En = en; Boy = boy;
        }
        public void Yaz()
        {
            Console.WriteLine("***************");
            Console.WriteLine("En:{0,5}", En);
            Console.WriteLine("Boy:{0,5}", Boy);
            Console.WriteLine("Alan:{0,5}", Alan());
            Console.WriteLine("***************");
        }
    }

    class KrediHesabi
    {
        public ulong HesapNo;
    }

    class Ogrenci
    {
        public ulong OgrenciNo;
        public string Ad;
        public string Soyad;
        public string Bolum;
        public string Sinif;
    }

    class SinifIsmi
    {
        public int ozellik1 = 55; // başlangıç değerleri verildi.
        public string ozellik2 = "deneme";
        public float ozellik3 = 123.78f;

        public int metot1(int a, int b)
        { return a + b; }


        public void metot2(string a)
        {
            Console.WriteLine(a);
        }
    }
    class Program
    {

        public int Zar()
        { Random rnd = new Random(); return rnd.Next(1, 7); }

        public static void metotlar(int a, int b, int c)
        { Console.WriteLine("a= " + a + " b= " + b + " c= " + c); }

        static float Fonksiyon(float x) { return 2 * x + 5; }
        static float TersFonksiyon(float x) { return (x - 5) / 2; }
        static int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriyel(a - 1); //fonksiyon kendi içerisinde çağrıldı
        }
        static void Yaz(object o)
        {
            Console.WriteLine("1.Metot:" + o);
        }
        static void Yaz(params object[] o)
        {
            if (o.Length == 0) return;
            Console.Write("2.Metot:");
            foreach (object n in o)
                Console.Write(n.ToString() + " ");
            Console.WriteLine();
        }
        static int Islem(string a, params int[] sayilar)
        {
            if (a == "carp")
            {
                if (sayilar.Length == 0) return 1;
                int carpim = 1;
                foreach (int i in sayilar) carpim *= i;
                return carpim;
            }
            else if (a == "topla")
            {
                if (sayilar.Length == 0) return 0;
                int toplam = 0;
                foreach (int i in sayilar) toplam += i;
                return toplam;
            }
            else return 0;
        }
        static void Metot1(int x, int y, int z)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }
        static void Metot1(double x, double y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }

        static void DegerTipAktarim(int Sayi)
        {
            Sayi = 30;
        }
        static int BuyukBul(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static int BuyukBul3(int a, int b, int c)
        {
            return BuyukBul(a, BuyukBul(b, c));
        }
        static void DiziYaz(int[] a, int Sekil)
        {
            if (Sekil == 0)
            {
                foreach (object o in a)
                {
                    Console.Write(o.ToString() + " ");
                }
                Console.WriteLine();
            }
            else if (Sekil == 1)
            {
                int x = 1;
                foreach (Object o in a)
                {
                    Console.Write("{0,5}", o.ToString());
                    if (x % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                    x++;
                }
            }
            else
            {
                foreach (Object o in a)
                {
                    Console.WriteLine(o.ToString());
                }

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            #region 3. ÖDEV  Slayt1 Örnek1 

            Console.WriteLine("Bu benim ilk C# programım");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV  Slayt3 Örnek1

            int a = 2; int b = 3; int c = 6; int d = 1;
            /* (a < b) = bu ifadenin doğru (true) olduğunu biliyoruz
            (c < d) = bu ifadenin yanlış (false) olduğunu biliyoruz */
            Console.WriteLine(" (a<b)&&(c<d) --> " + ((a < b) && (c < d)));
            Console.WriteLine(" (a<b)||(c<d) --> " + ((a < b) || (c < d)));
            Console.WriteLine(" ! (a<b) -->" + (!(a < b)));
            Console.WriteLine(" (a<b)&(c<d) --> " + ((a < b) & (c < d)));
            Console.WriteLine(" (a<b)|(c<d) --> " + ((a < b) | (c < d)));
            Console.WriteLine(" (a<b)^(c<d) --> " + ((a < b) ^ (c < d)));

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt3 Örnek2

            //int a = 2; int b = 3; int c = 6;
            Console.WriteLine(" (a & b) --> " + (a & b));
            Console.WriteLine(" (a | b) --> " + (a | b));
            Console.WriteLine(" (a ^ b) --> " + (a ^ b));
            Console.WriteLine(" ( ~a ) --> " + (~a));
            Console.WriteLine(" ( ~b ) --> " + (~b));
            Console.WriteLine(" ( ~c ) --> " + (~c));

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt3 Örnek3

            int i = 0; //döngü kontrol değişkeni
            while (i < 5)
            {
                Console.WriteLine("i = " + i);
                i++;
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt3 Örnek4

            i = 0;
            do
            {
                Console.WriteLine("i = " + i);
                i++;
            } while (i < 0);

            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt3 Örnek5

            int secim;

            do
            {
                Console.WriteLine("İşlemler \n=========");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bölme");
                Console.WriteLine("0 - Çıkış\n");
                Console.WriteLine("İşleminizi Seçin:");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1: Console.WriteLine("Toplama işlemi seçildi."); break;
                    case 2: Console.WriteLine("Çıkarma işlemi seçildi."); break;
                    case 3: Console.WriteLine("Çarpma işlemi seçildi."); break;
                    case 4: Console.WriteLine("Bölme işlemi seçildi."); break;
                    case 0: Console.WriteLine("Çıkış seçildi."); break;
                }
            }
            while (secim != 0);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt3 Örnek6

            for (int v = 0, j = 0; v < 20; v++, j++)
            {
                v *= j;
                Console.WriteLine("x = " + v + " j = " + j);
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt3 Örnek7

            string s;
            Console.WriteLine("Bir s String'i giriniz(Uygulamadan Çıkmak için 'Çıkış' yazınız):");
            for (s = Console.ReadLine(); s != "Çıkış"; s = Console.ReadLine())
            {
                Console.Write("Girdiğiniz s String'i: ");
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt3 Örnek8

            int f = 0, g, n;
            Console.Write("Bir Sayı Girin :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artım Miktarı :");
            g = Convert.ToInt32(Console.ReadLine());

            for (; f < n;)
            {
                Console.Write("{0} ", f);
                f += g;
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt3 Örnek9

            int k, t, toplam, n1, n2;
            Console.WriteLine("Aralık Başlangıcı :");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aralık sonu           :");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= n2)
            {
                for (k = n1; k <= n2; k++)
                {
                    toplam = 0;
                    for (t = 1; t <= k; t++)
                    {
                        if (k % t == 0)
                        {
                            toplam = toplam + t;
                        }
                    }
                    if (toplam == k + 1)
                    {
                        Console.WriteLine(k);
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir aralık giriniz...");
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt3 Örnek10

            int sayi;
            Console.WriteLine("Bir tam sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int bit = 32; bit >= 1; bit--)
            {
                Console.Write("{0}", (sayi >> bit - 1) & 1);
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt4 Örnek1

            Random r = new Random();

            int[] dizi = new int[20];
            char[] chr = new char[20];

            for (i = 0; i < 20; i++)
            {
                dizi[i] = r.Next(1, 51);
                chr[i] = (char)r.Next(20, 126);
            }
            for (i = 0; i < 20; i++)
            {
                Console.Write("{0,2}. değer {1,2} -> ", i, dizi[i]);
                for (int j = 0; j < dizi[i]; j++)
                {
                    Console.Write(chr[i]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt4 Örnek2

            int[,] dizi1 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(dizi1[i, j]);
                }
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt4 Örnek3

            int[][] dizi2 = new int[3][];

            dizi2[0] = new int[] { 1, 2 };
            dizi2[1] = new int[] { 3, 4, 5, 6, 7 };
            dizi2[2] = new int[] { 8, 9, 0 };

            foreach (int[] boyut in dizi2)
            {
                foreach (int eleman in boyut)
                {
                    Console.Write("{0,3}", eleman);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt4 Örnek4

            int[,] d1 = { { 2, 3 }, { 4, 5 }, { 6, 7 } }; // 3x2 lik int dizi.
            d1[2, 1] = 33;
            Console.WriteLine(d1.GetValue(2, 1)); // 7 değerini yazacak
            int[][] dd = new int[2][]; // şekildeki düzensiz dizi oluşturuluyor.
            dd[0] = new int[2]; //ilk satırın 2 sutunlu olacağı
            dd[1] = new int[1]; //ikinci satırın 1 sütunlu olacağı
            dd[0][0] = 23;
            dd[0][1] = 234;
            dd[1][0] = 44;
            Random rnd = new Random();
            int[] dizi3 = new int[3];
            dizi3[0] = rnd.Next(2, 10); // 2 ile 10 arası rastgele sayı
            dizi3[1] = rnd.Next(50); //0 ile 50 arası
            dizi3[2] = rnd.Next(); //rastgele integer değer
            Console.WriteLine(dizi.GetValue(2));//dizi değişkeninin 2. indis elemanını (3.eleman) yazar.
            Console.WriteLine(dd[1][0]);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt4 Örnek5

            string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" };
            Console.WriteLine("aranan isim=");
            string aranan = Console.ReadLine();
            foreach (String ss in isimler)
            {
                if (aranan.Equals(isimler[0]))
                    Console.WriteLine("aranan isim bulundu...");
                else Console.WriteLine("isim yok");
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt4 Örnek6

            int s1, s2;
            Console.Write("1. Sayıyı Girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Girin:");
            s2 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk = BuyukBul(s1, s2);

            Console.WriteLine("En Büyük: {0}\'dir", enbuyuk);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt4 Örnek7

            int s3;
            Console.Write("1. Sayıyı Girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı Girin:");
            s3 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk3 = BuyukBul3(s1, s2, s3);

            Console.WriteLine("En Büyük: {0}\'dir", enbuyuk3);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            #endregion

            #region 3. ÖDEV Slayt4 Örnek8

            int[] dizi4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            DiziYaz(dizi, 0);
            DiziYaz(dizi, 1);
            DiziYaz(dizi, 2);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt4 Örnek9

            int z = 100;
            Console.WriteLine(z);

            DegerTipAktarim(z);
            Console.WriteLine(z);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt4 Örnek10

            Metot1(5, 6);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();

            Metot1(5, 6.4f);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt4 Örnek11

            Metot1('f', 'g');

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion
            #region 3. ÖDEV Slayt4 Örnek12

            Metot1(3, 3, 6);
            Metot1(3.4f, 3);
            Metot1(1, 'h');

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt4 Örnek13

            Console.WriteLine(Islem("topla", 3, 4, 7, 8));
            Console.WriteLine(Islem("carp", 5, 23, 6));

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt4 Örnek14

            Yaz(25);
            Yaz("Deneme1", "Deneme2");
            Yaz('a');
            Yaz('z', 1, 23f, 4, 56, "abc");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt4 Örnek15

            Console.Write("Faktöriyelini alacağınız sayıyı giriniz :");
            int fak_değeri = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Girmiş olduğunuz sayının faktöriyeli :" + Faktoriyel(fak_değeri));

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek1

            Ev ev = new Ev();

            ev.Baba();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            ev.Anne();

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek2

            MetotSinif nesne = new MetotSinif();
            nesne.SayiBelirle(34);
            Console.WriteLine(nesne.SayiyiAl());


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek3

            Set_Get nesne1 = new Set_Get();
            nesne1.SahteOzellik = 110;
            Console.Write(nesne1.SahteOzellik);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek4

            float x = 10;
            Console.WriteLine(Fonksiyon(x));
            Console.WriteLine(TersFonksiyon(x));
            Console.WriteLine(Fonksiyon(TersFonksiyon(x)));

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek4

            Ogrenci ogr = new Ogrenci();

            Console.WriteLine(ogr.OgrenciNo);
            Console.WriteLine(ogr.Ad);
            Console.WriteLine(ogr.Soyad);
            Console.WriteLine(ogr.Bolum);
            Console.WriteLine(ogr.Sinif);


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek4

            KrediHesabi hesap1 = new KrediHesabi();
            KrediHesabi hesap2 = new KrediHesabi();
            hesap1.HesapNo = 3456;
            hesap2.HesapNo = 1111;
            Console.WriteLine(hesap1.HesapNo);
            Console.WriteLine(hesap2.HesapNo);


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion


            #region 3. ÖDEV Slayt5 Örnek5

            SinifIsmi nesne5 = new SinifIsmi();
            Console.WriteLine(nesne5.ozellik1);
            Console.WriteLine(nesne5.ozellik2);
            Console.WriteLine(nesne5.ozellik3);
            Console.WriteLine(nesne5.metot1(2, 5)); nesne5.metot2("deneme");


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek6

            Dortgen dortgen = new Dortgen();
            dortgen.EnBoyBelirle(20, 50);
            dortgen.Yaz();
            Dortgen d2 = new Dortgen();
            d2.EnBoyBelirle(25, 12); d2.Yaz();



            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek7

            Program aa = new Program();
            metotlar(aa.Zar(), aa.Zar(), aa.Zar());




            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            #region 3. ÖDEV Slayt5 Örnek7


            B bb = new B();
            bb.Metot1();




            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            #endregion

            Console.ReadKey();

        }
    }
}
