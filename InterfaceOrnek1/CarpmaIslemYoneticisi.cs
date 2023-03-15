using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek1
{
    internal class CarpmaIslemYoneticisi:Islem,IislemYap
    {
        public CarpmaIslemYoneticisi()
        {
            IslemTuru = IslemTurleri.Carpma;
            
        }

        public void IslemSonucunuYazdir()
        {
            Console.WriteLine("30 ile 20 çarpım sonuç" + 600);
        }

       
    }
}
