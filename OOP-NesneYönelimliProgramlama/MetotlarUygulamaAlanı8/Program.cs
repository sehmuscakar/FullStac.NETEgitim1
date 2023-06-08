using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarUygulamaAlanı8
{
    internal class Program
    {
        static void Main(string[] args)// ana metot ,statik özeliği de program açıldığında otomatik olarak nesne oluşturyor
        {
            // ToplamaYap();
            //  ToplamaYap();
            //ToplamaYap();

            Console.WriteLine("Bir cümle yazıp enter a basınız");
            string s = Console.ReadLine();//ekrandan okuduuğumuz satırı metin değişkenine aktarıyoruz
            Console.WriteLine("küçük harf sayısı : " + kucukharfsay(s));//burda metoda gömülüyor s paremetresi,kucukharfsay metodun metin değişkeni değerini yolladık 

            Birlestir("Şehmus", soyad: "ÇAKAR");

            Console.WriteLine("Lütfen mail adresinizi giriniz");
            var email = Console.ReadLine();
            if (MailGonder(email) == false)
            {
                Console.WriteLine("Mail Adresi boş geçilmez!");
            }
            else Console.WriteLine("Mail kabul edildi");

            Console.ReadLine();
        }

        static void ToplamaYap()// void metotlar geriye değer döndürmez 
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayii1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem Sonucu:" + (sayii1 + sayi2));
        }

        static int kucukharfsay(string s)//Geriye int veri tipinde değer döndüren ve paremtre olarak string değişken alan metot 
        {
            int kucukharfsayisi = 0;//sayacağımız küçük harf sayısını tutmak için değişkenimiz
            foreach (var harf in s)
            {
                if (char.IsLower(harf)) kucukharfsayisi++;//KAREKTERE OLARAK harfleri sayıyor küçük olanları sayıyor,eğer ekrandan okunan metin içerisinde harf küçükse kucukharfsayısı değerini 1 artır

            }
            return kucukharfsayisi;// geriye döndürülen değer
        }
   
    static void Birlestir(string ad,string soyad)//Birleştir ismini verdiğiğimiz metot dışarıdan iki adet paremetre alıyor ad ve soyad
        {
            Console.WriteLine("Hoşgeldin:" +ad + " " +soyad);//paremetreden gelen değerleri önüne tanımlama yazıp birleştirerek ekrana yazıyor
        }
    
        static bool MailGonder(string mailAdresi)
        {
            if (!string.IsNullOrWhiteSpace(mailAdresi))//Eğer mailAdresi değişkenine bir değer girilmişse,yani mail adresi boş değilse
            {
                return true;//geriye true değeri döndür
            }
            else return false;//mailAdresi değişikeni boşsa geriye false döndür
        }



    }
}
