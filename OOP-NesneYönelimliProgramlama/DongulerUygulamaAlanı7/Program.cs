using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongulerUygulamaAlanı7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("For Döngüsü");
            int toplam = 0;
            int length = 10;
            for(int i=0; i<length; i++)
            {
                toplam += i;
                Console.WriteLine("i değişkeninin değeri {0} taoplamın değeri {1}", i, toplam);

            }
            Console.WriteLine("Tolam:" + toplam);
            */


            /*
            Console.WriteLine("While Döngüsü");
            int i = 0;
            while (i<5)
            {
                Console.WriteLine("While Döngüsü{0}",i);// toplamın değeri ekrana yazdırıyoruz
                i++;//toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin prıgram 
            }
           */

            /*

            Console.WriteLine("Do While Döngüsü");
            int toplam = 3;
            do// while dan farkı şart olmasada biir kez çalışır do döngüsü ilk önce işlme sonra şart 
            {
                Console.WriteLine("Do While sayı {0}",toplam);//toplamın değerini ekrana yazdırıyoruz
                toplam++;// toplam sayısını arttırıyoruz ki sonsuz döngüye girmesin program 
            } while (toplam < 9);
            */
            
            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };
            string[] isimler2 = { "Mustafa", "Temel", "Mehmet" };
            Console.WriteLine("Foreach Döngüsü");
            foreach (var item in isimler2)
            {
                Console.WriteLine("Öğrenci Adı :"+item);
            }

            foreach (var item in ogrenciler2)
            {
                Console.WriteLine("Öğrenci Numarası :" + item);
            }
            

            
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("i değişkenin değeri {0}", i);

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("\t j değişkenin değerii {0}",j);
                }
            }
            
            Console.WriteLine("iç içe foreach döngüsü");
            foreach(var isim in isimler2)
            {
                Console.WriteLine("Öğrenci Adıı:" + isim);
                foreach(var ogrencino in ogrenciler2)
                {
                    Console.WriteLine("Öğrenci No:" + ogrencino);
                }
            }


            Console.ReadLine();

        }
    }
}
