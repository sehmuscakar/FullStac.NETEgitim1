using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUygulamaAlanı9
{
    //Sınıf (Class) soyut veri tipidir.Nesne (object) onun somutlaşan bir cismidir.

    class Ev// Ev isminde soyut bir sınıf oluşturuyoruz
    {
       internal int KapiNo; // internal aynı namespace adı altındaki calssların birbirine ulaşmasını sağlıyor.
        internal string sokakAdi;
        internal string İlce;
        internal string Sehir;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev ilkev = new Ev();// ev sınıfından  ilkev isminde bi rnesne türetiyoruz
            ilkev.İlce = "Merkez";
            ilkev.Sehir = "Batman";
            ilkev.sokakAdi = "Gültepe";
            ilkev.KapiNo = 20;

            Console.WriteLine("Ev adresi:" + ilkev.sokakAdi + "\n kapı no:" + ilkev.KapiNo);

            Ev memlekettekiEv = new Ev()
            {
                Sehir = "MERSİN",
                KapiNo = 10,
                sokakAdi = "erdemli sokak"
        };
            memlekettekiEv.İlce = "Erdemli";

            //diğer yazım formatı da aşahıdaki şekilde {} yer tutucu operatörü ile 
            Console.WriteLine("Ev adresi : {0} \n Kapı no: {1}", memlekettekiEv.sokakAdi, memlekettekiEv.KapiNo);

            HariciClassolusturma yenikullanici = new HariciClassolusturma();//diğer class(sınıf)
            yenikullanici.Aktif = true;
            yenikullanici.KullaniciAdi = "Admin";
            yenikullanici.Sifre = "123456";
            //  Console.WriteLine($"Kullanıcı aktif mi?:{yenikullanici.Aktif}\n Kullanıcı Adı :{yenikullanici.KullaniciAdi} \n şifreniz: {yenikullanici.Sifre}"); // buda c# aşka bir yazık şekli 

            yenikullanici.EkranaYaziYaz("Merhaba dünya");
            Console.Write("İkisayının toplamı :" + yenikullanici.ToplamaYap(20, 15));

            Console.WriteLine(HariciClassolusturma.SinifDegiskeni);// statikleri direk böyle kullanabiliyorsun




            Console.WriteLine("Mail adresinizi giriniz!");
            var mailAdresi=Console.ReadLine();
            var islemSonucu = yenikullanici.MailGonder(mailAdresi);
            if (islemSonucu == true)
            {
                Console.WriteLine("Mailiniz başarıyla iletildi..");
            }
            else Console.WriteLine("Mail adresi boş olamaz!");


            
            
            
                
            
            
            Console.ReadLine();


        }
    }
}
