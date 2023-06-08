using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructYapilarUygulamaAlanı12
{





    struct yapi
    {
        // pubnlic string ad="şehmus";// struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanmaz

        public int sayi;
        public string metin;

        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }

    class Program
    {

        struct Kimlik
        {
            // Kimlik struct'ının değişkenleri
            public string ad;
            public string soyad;
            public int yas;
            public string dogumyeri;
            public DateTime DogumTarih;


            public struct Adres
            {
                public int Id { get; set; }
                public int KapiNo { get; set; }
                public string Sehir { get; set; }
                public string Ilçe { get; set; }
                public string AçıkAdres { get; set; }
            }
        }
        static void Main(string[] args)
        {
            //Struct ile yapı kuurma

            Kimlik kimlik = new Kimlik();
            kimlik.ad = "Şehmus";
            kimlik.soyad = "Çakar";
            kimlik.dogumyeri = "Batman";
            kimlik.yas = 21;

            //Struct ile kurulan yapıyı kullanma

            Console.WriteLine("Kimlik Bilgileri:");
            Console.WriteLine("Ad:{0},Soyad:{1}",kimlik.ad,kimlik.soyad);
            Console.WriteLine("Doğum Yeri :"+kimlik.dogumyeri);
            Console.WriteLine("Yaşı :" + kimlik.yas);

            Console.ReadLine();
        }
    }
}
