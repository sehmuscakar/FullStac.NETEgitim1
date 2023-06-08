using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarUygulamaAlani14
{
     class Program
    {
        //Enum(Numaratör) lar nesneleri numaralandırmak için kullanılır
        enum Aylar : byte
        {
            Ocak,şubat,Mart,Nisan,Mayıs,Haziran,Temmuz,Ağustos,Eylül,Ekim,Kasım,Arlık
        }

        enum CalisanGunler
        {
            Pazartesi,Salı,Çarşamba,Perşembe,Cuma
        }

        enum SiparisDurumu
        {
            Hazuırlanıyor,Hazırlandı,KargoBekleniyor,Kargolandı
        }

        enum Meyveler : int
        {
            Elma = 3 , Armut = 7 , Çilek = 1
        }

        static void Main(string[] args)
        {
            //Byte(byte) tam sayıları tuttuğumuz 8 bitlik veri depolayan bir değer tipidir. Byte veri tipi 0 ile 255 arasında ki değerleri alabilir.
            //Görüldüğü üzere eksi (negatif) bir tam sayı değeri alamaz
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;

            Console.WriteLine("Armut={0},Elma{1},Çilek{2}", a, b, c);
            Console.Read();

        }

        static void ornek()
        {
            int siparisDurum = 1;
            if (siparisDurum == 0) Console.WriteLine("Siparis Durumu: {0}", SiparisDurumu.Hazuırlanıyor);
            if (siparisDurum == 1) Console.WriteLine("Siparis Durumu: {0}", SiparisDurumu.Hazırlandı);
            if (siparisDurum == 2) Console.WriteLine("Siparis Durumu: {0}", SiparisDurumu.KargoBekleniyor);
            if (siparisDurum == 3) Console.WriteLine("Siparis Durumu: {0}", SiparisDurumu.Kargolandı);

        }
    }
}
