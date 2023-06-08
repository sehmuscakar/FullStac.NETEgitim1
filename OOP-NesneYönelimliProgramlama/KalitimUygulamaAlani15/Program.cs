using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimUygulamaAlani15
{
    //Kalıtım-Inherfitance
    class AtaSinif
    {
    
        public AtaSinif()
        {
            Console.WriteLine("AtaSinif kurucu metodu çalıştı");
        }

        public void Yaz()
        {
            Console.WriteLine("AtaSinif içerisinde Yaz metodu çalıştı");
        }

    }
   
    class OgulSinif : AtaSinif
    {
        public OgulSinif()
        {
            Console.WriteLine("OgulSinif kurucu metodu çalıştı");
        }
    }



     class Program
    {
        static void Main(string[] args)
        {
            OgulSinif ogul=new OgulSinif();
           // ogul.Yaz();

            ApartmanKati apartmanKati = new ApartmanKati();
            apartmanKati.sahip = "Şehmus Bey";
            apartmanKati.EvSahibiniYaz(apartmanKati.sahip);

            apartmanKati.apartmanYoneticisi = "Çevdet Bey";
            apartmanKati.ApartmanYoneticisiniYaz(apartmanKati.apartmanYoneticisi);

            Cizici[] bircizici=new Cizici[4];// 4 elemanlı bir dizi oluşturduk cizici sınıfından 
            bircizici[0] = new DogruCiz();//1 ciye dogruciz classını atadık
            bircizici[1] = new DaireCiz();
            bircizici[2] = new KareCiz();
            bircizici[3] = new Cizici();
            foreach(var item in bircizici) 
            {

                item.Ciz();

            }
            Console.Read();
        }
    }

    class Ev
    {
        public string sahip;

        public void EvSahibiniYaz(string sahip)
        {
            Console.WriteLine("Ev sahibi :" + sahip);
        }
    }

    class ApartmanKati : Ev
    {
        internal string apartmanYoneticisi;

        public void ApartmanYoneticisiniYaz(string yonetici)
        {
            Console.WriteLine("Apartman Yöneticisi :" + yonetici);
        }
    }


    //polimorfizm (çok biçimlilik)

   public class Cizici
    {
        public virtual void Ciz()//virtual ibresi ile metodumuzu ezilebilir hale getirdik
        {
            Console.WriteLine("Çizici");
        }
    }

    public class DogruCiz: Cizici
    {
        public override void Ciz()//override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Düz çizgi");
        }
    }

    public class DaireCiz : Cizici
    {
        public override void Ciz()//override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Daire");
        }
    }

    public class KareCiz : Cizici
    {
        public override void Ciz()//override ibaresi ile ciz metodumuzu ezerek farklı çıktı üretmesini sağladık
        {
            Console.WriteLine("Kare");
        }
    }

}
