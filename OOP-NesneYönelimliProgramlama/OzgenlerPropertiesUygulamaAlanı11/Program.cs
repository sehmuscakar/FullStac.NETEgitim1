using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgenlerPropertiesUygulamaAlanı11
{
    class Skorlar
    {
        private int skor;

        public int Skor//Skor isminde property tanımladık
        {
            get { return skor; }//get bloku return skor;deyimi ile private skor değişkenini okuyor ve çağırıldığı yere bu değeri dönüyor

            set { skor = value; }//set bloku skor=value; deyimi ile sınıfın private değişkenine value değerini atıyor
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Skorlar skorlar = new Skorlar();
            skorlar.Skor = 20;
            Console.WriteLine(skorlar.Skor);

            kisi kisi= new kisi();
            kisi.Ad = "Şehmus";
            kisi.Aktif = true;

            if(kisi.Aktif==true)
            {
                Console.WriteLine("Hoşgeldin" + kisi.Ad);

            }


            Console.Read();
        }
    }
}
