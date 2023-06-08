using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapılarıUygulamaAlani6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int sayi = -10;
            if (sayi > 0)// eğer sayı değişkeninin değeri 0 dan büyükse   
            {
                Console.WriteLine("Sayi pozitiftir");
            }
            else if(sayi==0)
            {
                Console.WriteLine("Sayi Sıfırdır.");
            }
            else
            {
                Console.WriteLine("Sayi negatiftir");
            }
            */

            // kullanıcı giriş sistemi
            /*
            Console.WriteLine("Kullanıcı Adınızı Giriniz");
            string kullaniciAdi = Console.ReadLine();//Console.Readline() metodu ekrandan girilen değeri yakalar ve kullaniciadi değişkkenine atar
            Console.WriteLine("Şifrenizi Giriniz");
            string sifre=Console.ReadLine();//Console.readline() metodu ekrandan girilen değeri yakalar ve sifre değişkenine atar 

            string veritabanindakikullaniciAdi = "admin";
            string veritabanindakisifre = "123456";

            if(kullaniciAdi== veritabanindakikullaniciAdi && sifre == veritabanindakisifre)
            {
                Console.WriteLine("Sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifrenizde hata var!");
            }
            */
            // ehliyet alma uygulaması
            /*
            Console.WriteLine("Yaşınızı Giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());//console.readline() metodu ekrandan aldığı veriyi string veri tipinde bize döndürür,
            //convert metoduyla sayısal string veriyi int e çevirebiliriz.

            string ogrenim = "ilkokul";
            if (yas >= 18)
            {
                if (ogrenim == "lise" || ogrenim == "üniversite") Console.WriteLine("Ehliyet alabilirsiniz.");
                else Console.WriteLine("Öğrenim durumunuz ehliyet için yeterli değil.");

            }
            else Console.WriteLine("Ehliyet için yaşınız tutmuyor.");
            */


            Console.WriteLine("1 ile 12 arasında bir sayı giriniz:");

            int ay = DateTime.Now.Month;  //Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimi");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimi");
                    break;
                    case 9:
                    case 10:
                    case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                     break;
                default:
                    Console.WriteLine("Yanlış bilgi.");
                    break;
            }



            Console.Read();
        }
    }
}
