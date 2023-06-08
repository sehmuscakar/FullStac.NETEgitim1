using System;//bu kütüphameler referanslardan geliyor 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaAlanı1// bu kısımda aslında bir kkütüphane gibi davranıyor başka bir projede isim uzayını vererek bu blogun içindeki kodları kullanabilir.
{
    //başka bir rojjede Using UygulamaAlanı1 diyerek bu kütüphaneyi kullanabileceksin
    //eğer sen bu dosyada değişiklik yaparsan yuakrda sekme kısmında yıldız işareti oluyor,kaydetiğinde yıldız işareti gidiyor
    //bu siyah ekranda açlışıyor cmd de yani 
    internal class Program
    {//consol ekkranı: cmd ekranı
        static void Main(string[] args)//örnek Main metodu
        {
            Console.Write("Bu bizim ilk program kodumuz");//console sınıftır.write metotur.write ekrana yazı yazdırır.
                                                          //Program.Main(); örnek yani System kütüphanesinin içindeki hazır metotlardır.

            Console.Read();// programın ekranda kalmasını sağlar

        }
    }
}
