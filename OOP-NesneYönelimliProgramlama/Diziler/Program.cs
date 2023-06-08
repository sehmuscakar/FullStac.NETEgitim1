using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizi oluşturma 

            int[] sayi;//veri tipini belirtikten sonra köşeli parentez koyup dizi ismini vererek dizimizi oluşturmuş oluyoruz
            int[] ogrenciler = new int[7];//öğrenciler isminde int veri taşıyan ve 7 elemandan oluşan bir dizi oluşturduk
                                          //Dizilerde indis denile vardır ve içine eklenecek elemanlar 0 dan başlar

            ogrenciler[0] = 5;
            ogrenciler[1] = 200;
            ogrenciler[2] = 60;
            ogrenciler[3] = 15;
            ogrenciler[4] = 25;
            ogrenciler[5] = 35;
            ogrenciler[6] = 45;
            //ogrenciler[7]=600;
            //dizilere başlangıçta kaç elemndan oluşacağı tanımlanmışsa o sayının dışına çıktığımızda hata alırız
            ogrenciler[5] = 550;

            string[] isimler = new string[5];
            isimler[0] = "Mustafa";
            isimler[1] = "Tamer";
            isimler[2] = "Mehmet";
            isimler[3] = "Berfin";
            isimler[4] = "Ahmet";
            Console.WriteLine(isimler[3]);

            int[] ogrenciler2 = { 1, 2, 3, 4, 5 };// bir diğer dizi oluşturma yöntemi,bu yöntemde diziye kaç elemandan oluşacağı
                                                  //bilgisi verilmez ve diğerler diziye eklenir.bu durumda dizi kaç elemandan oluştuğunu içine eklenen elemanları sayarak kendisi bilir.

            Console.WriteLine(ogrenciler2[0]);
            ogrenciler2[0] = 319;
            Console.WriteLine(ogrenciler2[0]);


            string[] isimler2 = { "Mustafa", "Tamer", "Mehmet"};
            Console.WriteLine(isimler[0]);
            isimler2[2] = "Ahmet";
            Console.WriteLine(isimler2[2]);

            //diğer dizi türleri
            //2 boyutlu diziler
            int[,] arr2Boyut;//2 boyutlu dizi oluşturma

            int[,] ikilsayi = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(ikilsayi[0,0]+"\t");
            Console.WriteLine(ikilsayi[0,1]+"\t");
            Console.WriteLine(ikilsayi[1,0]+"\t");
            Console.WriteLine(ikilsayi[1,1]+"\t");
            Console.WriteLine(ikilsayi[2,0]+"\t");
            Console.WriteLine(ikilsayi[2,1]+"\t");



            //3 boyutlu diziler
            int[,,] arr3Boyut;//3 boyutlu dizi oluşturma

            //4 boyutlu diziler
            int[,,] arr4Boyut;//4 boyutlu dizi oluşturma


            Console.Read();


        }
    }
}
