using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek1
{
    internal abstract class Islem:IislemİsmiYazdirir
    {
        public IslemTurleri IslemTuru { get; set; }

        public void IslemIsmiYazdir()
        {
            //örn: toplama-->1
            Console.WriteLine($"{IslemTuru}---->{(byte)IslemTuru}");
        }
    }

    enum IslemTurleri:byte
    {
        
        Toplama=55,
        Cikarma=1,
        Carpma=249
     
    }
}
