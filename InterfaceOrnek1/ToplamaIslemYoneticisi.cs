using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek1
{
    internal class ToplamaIslemYoneticisi:Islem,IislemYap
    {
        public ToplamaIslemYoneticisi()
        {
            IslemTuru = IslemTurleri.Toplama;
        }
        public void IslemSonucunuYazdir()
        {
            Console.WriteLine("1.sayi gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayi gir");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sonuç:{s1+s2}");

        }
    }
}
