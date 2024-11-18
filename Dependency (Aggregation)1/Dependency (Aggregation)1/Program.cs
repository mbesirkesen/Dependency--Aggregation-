using System;
using System.Collections.Generic;
using System.Reflection;
//Bir evde birden fazla oda olabilir, ancak oda sınıfı, ev sınıfının bir parçasıdır fakat evin yokluğu oda için belirleyici değildir.
class Oda
{
    public string Boyut { get; private set; }
    public string Tip { get; private set; }
    public Oda(string boyut, string tip)
    {
        Boyut = boyut;
        Tip = tip;
    }
    public void OdaBilgisi()
    {
        Console.WriteLine($"Oda Boyutu: { Boyut}\n Oda Tip: { Tip}");
    }
}
class Ev
{ 
    public string Ad { get; private set; }
    public List<Oda> Odalar { get; private set; }
    public Ev(string ad) 
    {
        Ad = ad;
        Odalar = new List<Oda>();
    }
    public void OdaEkle(Oda oda)
    {
        Odalar.Add(oda);
    }
}

//Bir şirkette birden fazla çalışan olabilir, ancak çalışanlar bağımsız bir şekilde yaşamaya devam edebilirler, şirket yok olduğunda da varlıklarını sürdürebilirler.

class Şirket
{
    public string Ad { get; private set; }
    public List<Calısan> Calısanlar { get; private set; }
    public Şirket(string ad)
    {
        Ad = ad;
        Calısanlar = new List<Calısan>();
    }
    public void CalısanEkle(Calısan calısan)
    {
        Calısanlar.Add(calısan);
    }
}
class Calısan
{
    public string CalısanAd { get; private set; }
    public string Pozisyon {  get; private set; }
    public Calısan(string calısanAd, string pozisyon)
    {
        CalısanAd = calısanAd;
        Pozisyon = pozisyon;
    }
    public void CalısanBilgisi()
    {
        Console.WriteLine($"Calısanın Adı: {CalısanAd}\nPozisyonu: {Pozisyon}");
    }

}

//Bir kütüphane birçok kitaba sahip olabilir, ancak kitaplar kütüphaneden bağımsız olarak var olabilir.
class Kutuphane
{
    public string KutuphaneAd { get; private set; }
    public List<Kitap> Kitaplar { get; private set; }
    public Kutuphane(string kutuphaneAd)
    {
        KutuphaneAd = kutuphaneAd;
        Kitaplar =new List<Kitap>();
    }
    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }
}
class Kitap
{
    public string Baslik { get; private set; }
    public string Yazar {  get; private set; }
    public void KitapBilgisi()
    {
        Console.WriteLine($"Kitabın Başlığı: {Baslik}\nYazarı: {Yazar}");
    }
}