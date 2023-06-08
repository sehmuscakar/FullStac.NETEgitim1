using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelitecleriUygulamaAlanı10
{
    //aynı namespaceyi kullanan classlar aynı projede diyebiliriz 
    internal class Program
    {

        public class deneme
        {
            public string UrunAdi = "public öğeye herkes erişebilir";
        }


        protected class test // Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
        {
            string UrunAdi;
        }

        internal class urun// internal erişim belirteci etkin projeye ait sınıflardan erişilebeilir,onların dışında erişilemez
        {
            private string gizli = "private yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez";
        }



        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Ali";
            kullanici.Soyadi = "Cambaz";

            Console.WriteLine("Kullanıcı adı:" + kullanici.Adi);
            Console.WriteLine("Kullanıcı soyadı:" + kullanici.Soyadi);

            Console.Read();

        }
    }
}
