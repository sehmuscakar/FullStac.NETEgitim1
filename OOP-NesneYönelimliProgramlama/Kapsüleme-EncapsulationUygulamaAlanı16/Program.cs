using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsüleme_EncapsulationUygulamaAlanı16
{
    //kapsüleme:Encapsulation (Kapsülleme), verilerin tek bir birim altında toplanması olarak tanımlanır. Bu özellik, dilin nesne kullanıcısından gereksiz uygulama
    //ayrıntılarını saklayabilme yeteneği olarak ifade edilebilir. Bu sistem kod ile datayı birbirine entegre eden bir mekanizmadır.
  
    
    
    
    public class Bolum
    {
        private string BolumAdi;//dışarıdan erişime kapalı değişkenimiz.
        //Accessor (Getter)
        public string GetBolumAdi()
        
        { return BolumAdi; }

        //Mutator (Setter)
        public void SetBolumAdi(string a)
        {
            if (a == "Programlama")
            {
                Console.WriteLine("OKulumuzda {0} bölümü bulunmamaktadır!", a);
            }
            else BolumAdi= a;
        }


    }
    
   
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Lütfen bölüm adınızı giriniz");
            var bolumAdi = Console.ReadLine();
            /*  Bolum bolum = new Bolum();
              bolum.SetBolumAdi(bolumAdi);

              Console.WriteLine("Seçtiğiniz bölüm adı" + bolum.GetBolumAdi());

              Fakulte fakulte= new Fakulte();
              fakulte.Bolum= bolumAdi;
              Console.WriteLine("Seçtiniz bölüm adı :" + fakulte.Bolum);

            Universite universite = new Universite(bolumAdi);
            Console.WriteLine("Seçtiğiniz bölüm adı:" + universite.Bolum);*/

            YuksekOkul yuksekOkul= new YuksekOkul();
            yuksekOkul.Bolum = bolumAdi;

            Console.ReadLine();
        }
    }

    // Özgen (Property) Kullanarak kapsüleme

    class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; }// Veriyi geriye döndürür
            set//ayarlama yapar
            {
                if (value == "Programlama")
                {
                    Console.WriteLine("Okulumuzda {0} bölümü bulunmaktadır!", value);
                }
                else bolum= value;
            }
        }
    }
    //Yalnız okunur (Read only Property)
    class Universite
    {
        private string bolum;

        public Universite(string str) //ctor yazarak kısaca cunsaktır oluşturabilirsin
        {
            bolum= str;
        }

        public string Bolum
        {
            get { return bolum; }
        }
    }

    //Yalnızca Yazılır(Writeonly Property) Kullanarak Kapsülleme

    class YuksekOkul
    {
        private string bolum;

        public string Bolum
        {
            set
            {
                bolum= value;
                Console.WriteLine("Seçtiğiniz bölüm adı:" + bolum);
            }
        }
    }
}
