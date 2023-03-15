// See https://aka.ms/new-console-template for more information

using InterfaceOrnek1;


//ToplamaIslemYoneticisi toplamaYoneticisi = new ToplamaIslemYoneticisi();
//IislemİsmiYazdirir islemim2 = new ToplamaIslemYoneticisi();
//ToplamaIslemYoneticisi islemim3 = new ToplamaIslemYoneticisi();

//IislemİsmiYazdirir[] islemler = new IislemİsmiYazdirir[]
//{
//    toplamaYoneticisi
//};


//List<IislemİsmiYazdirir> islemListesi = new List<IislemİsmiYazdirir>();

ToplamaIslemYoneticisi t = new ToplamaIslemYoneticisi();
CarpmaIslemYoneticisi c = new CarpmaIslemYoneticisi();

List<IislemİsmiYazdirir> islemler = new List<IislemİsmiYazdirir> { t, c };

foreach (var item in islemler)
{
    item.IslemIsmiYazdir();
}
Console.WriteLine("\n");

bool kontrol = Int32.TryParse(Console.ReadLine(), out int sectigiIslem);
if (!kontrol)
{
    Console.WriteLine("lütfen geçerli seçim yapınız!");
}
if (sectigiIslem == (int)IslemTurleri.Toplama)
{
    t.IslemSonucunuYazdir();
}
else if (sectigiIslem == (int)IslemTurleri.Carpma)
{
    c.IslemSonucuYazdir();
}










