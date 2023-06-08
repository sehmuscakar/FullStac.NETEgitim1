using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaAlanı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veri Yapısı, Veri Tipi ve Değişken Mantığı
            //System.Console.Write("Şehmus Çakar");//Kütüphane,sınıf,metot
            //Console.Read();//console.read komutu ekrandan  karekterlik veri okur 

            //c# değişken tanımlama
            // c# ta değişken tanımlamak için önce değişkenin veri tipi sonra simi yazılıp;ile kod satırı sonlandırılr.
            //veri tipi ileilgili değişkenin hangi türde veri alabileceğini belirler.mesela tam sayı mesela kesirli sayı gibi 
            // byte tam sayılar içindir.



            //değişknelerde vee sabitlerde veri tutan sınıf öğeleridir.
            //ana belekte iki bölge var stack ve heap olmak üzere 
            //stcak:değer tipindeki değişkenler burda tutuluyor
            //heap:referans tipindeki değişkneler burda tutuluyor,sınıflara ait bütün nesneler burda tutulur..
            byte plaka_kodu = 255;//0-255 arası,tamsayı 
            int plaka=216355355;//32 bit 4byte +-2 ,f12 ile ilgili kodun özeliklerini görebilirsin içine girer 
         
            const int plaka3 = 20;

            Console.WriteLine("plaka kodu:"+plaka_kodu);//cw yap kısa yolu ,ctrl d ile satırı kopyasını alta da kopyalabilirsin 
            Console.WriteLine("plaka" + plaka);

            // kesirli sayı değişkenleri 
            float kesirliSayi = 4.9f;//4 byte yer kaplar 6-7 basamak 
            double kesirlisayi2 = 4.9; //8byte yer kaplar 15-16 basamak

            //Decimal veri tipi 
            decimal urunfiyat = 5500;//12byte ,duyarlı basamak 28-29 



            
            
            
            
            
            Console.Read();

        }
    }
}
