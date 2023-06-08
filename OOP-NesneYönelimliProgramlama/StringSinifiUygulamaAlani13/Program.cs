using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace StringSinifiUygulamaAlani13
{
     class Program
    {
        static void Main(string[] args)
        {

            string degiken;
            char karekter;
            string metinlericin = "mersin yazısı";
            int sayi = 26;
            Console.WriteLine(sayi);
            // Ornek1();

          //  StringMetotlari();
            Console.Read();
        }

        static void Ornek1()
        {
            string birMetin = "Batman Göneydoğudadır.";
            String birsayi = "12345678";
            System.String birTarih = "06.05.2023";

            string s = "ŞEHMUS ÇAKAR";

            for(int i=0; i<s.Length;i++)
            {
                Console.WriteLine("s[" + i + "]=" + s[i]);
            }

            foreach(var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());

        }

       

    static void StringMetotlari()
        {
            string metin = "Hi My name is slim shady";

            var result = metin.Length;//metin değişkenin uzunluğunu verir
            var result2 = metin.Clone();//Clone metodu metni çoğaltır

            metin = "My name is Ali/";

            bool result3 = metin.EndsWith("a");//metin a ile bitiyor mu?

            bool result4= metin.StartsWith("My name");//metin My name ile başlıyor mu?

            var result5 = metin.IndexOf("namee");//İndexof metodu metin içerisinde aradığımız karekteri bulamazsa geriye -1 döndürür

            var result6 = metin.IndexOf(" ");//indexof metodu metin içerisinde aradığımız karekteri bulursaa geriye karekterin index numarasını döndürür

            var result7 = metin.LastIndexOf("/");

            var result8 = metin.Insert(0, "Hello, ");

            var result9 = metin.Substring(2, 5);

            var result10 = metin.ToLower();
            var result11 = metin.ToUpper();
            var result12 = metin.Replace(" ","-");
            var result13 = metin.Remove(3, 4);

            //String sınıfına bir değer ataması yapmazsak varsayılan değeri null olur
            // String referans tiplidir,diğer değişken veri tipleri değer tiplidir.
            //- belek tipliler işleri bitince siliniyor,- referans tipliler ise cardon collecton sayesinde bellli araliklarla siliniyorr eğer biz yok etmezsek

            //String nesnedir değiştirilemez,bildirimi yapılan bir string zerinde bir değişiklik yapılırsa bu değişiklik arka tarafta başka bir stringin oluşmasına sebep olur

            Console.WriteLine("metin değişkenin değerini klonlayıp result2 ye yapıştır:" + result2);
            Console.WriteLine("metin değişkeni a ile mi bitiyor:" + result3);
            Console.WriteLine("metin değişkeni My name ile mi başlıyor?" + result4);
            Console.WriteLine("metin değişkeni içerisinde namee kelimesi var mı?" + result5);
            Console.WriteLine("metin değişkeninde boşluk var mı" + result6);
            Console.WriteLine("metin değişkeninde geçen son/karekteri kaçıncı indexte " + result7);
            Console.WriteLine("metin değişkenine 0. indexten başlayarak Hello, kelimesini ekle" + result8);
            Console.WriteLine("metin değişkenini 3.indexten başlayarak 4 karekterini al" + result9);
            Console.WriteLine("metin değişkenindeki karekterleri küçült" + result10);
            Console.WriteLine("metin değişkenini büyük harfe çevir" + result11);
            Console.WriteLine("metin değişkenindeki boşlukları - ile değiştir" + result12);
            Console.WriteLine("metin değişkenini 2. indexten başlayarak 5 karekter sil" + result13);


        }

        static void Kiyasla()
        {
            string kelime1 = "Ankara";
            string kelime2 = "İstanbul";
            string kelime3 = "Ankara";
            string kelime4 = "Ankara";

            Console.WriteLine(kelime1==kelime2);    
            Console.WriteLine(kelime1!=kelime2);    
            Console.WriteLine(kelime1==kelime4);    
            Console.WriteLine(kelime1==kelime3);


            Console.WriteLine("Ankara" == "ANKARA");
            Console.WriteLine("Ankara" != "ANKARA");

        }


    }
}
