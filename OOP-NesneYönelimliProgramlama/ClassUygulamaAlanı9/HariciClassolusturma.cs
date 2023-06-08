using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUygulamaAlanı9
{
    internal class HariciClassolusturma
    {

        string KurucuMetot;
        public HariciClassolusturma()// ctor kısaca yaz contsactır oluşturur(yapıcı metot)
        {
            KurucuMetot = "Sınıflarda constructor (kurucu metot) özeliği vardır ve bu metotlar sınıftan bir nesne oluştuğunda otomatik olarak çalışır ve içerisinde kodları " +
                "çalıştırır.Kurucu metotlar değişkenler gibi veri tipi almazlar ve void ifadesi de bulunmaz,sınıfın adıyla aynı ad kullanılarak oluşturulur.";
            //yukarıda tanımladığımız kurucu metot değişkenine sınıfımızın metodunda değer ataması yaptık
            Console.WriteLine(KurucuMetot); // ilerde bu sınıfı çağırısan sen bu kurucu metotdu çağırmasan bile otomatik men çalışır ilgili yerde 
        }

        public int Id;
        public string KullaniciAdi;
        public string Sifre;
        public bool Aktif;

        public void EkranaYaziYaz(string ekranaYazilacakYazi)
        {
            Console.WriteLine(ekranaYazilacakYazi);
        }

        public int ToplamaYap(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public bool MailGonder(string mail)
        {
            if (!string.IsNullOrWhiteSpace(mail))//boş değilse veya ...
            {
                //mail gonderme kodları burada olacak
                return true;
            }
            else return false;
        }

    

        public static string SinifDegiskeni = "Sınıflarda metot ve değişken de kullanabilriz";



    }
}
