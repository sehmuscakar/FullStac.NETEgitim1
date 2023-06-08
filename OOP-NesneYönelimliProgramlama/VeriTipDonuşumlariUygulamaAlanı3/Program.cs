using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipDonuşumlariUygulamaAlanı3
{
    internal class Program
    {
        //set as starttap project aptığında istediğin uyulama çalışır.
        static void Main(string[] args)
        {
            //veri tipi dönüşümleri(casting)

            int sayi1 = 45;
            long sayi2;
            sayi2= sayi1;//istemsiz dönüşüm(implicit)

            long sayi3 = 125633233;
            sayi1= (int)sayi3;// cast ile dönüştürdük hatada kırmızıya bas cast orda 
            //daha büyük bir veri tipinden daha küçük bir veri tipine dönüşüm yapmak istersek ilgili değerin önüne parentez içinde dönüştürmek istediğimiz
            //veri tipini yazarız buna istemli(explicit) dönüşüm denir.
            //not:bu tür dönüşümler yalnızca sayısal için yapılabilir string ya da bool tipleri arasında yapılamaz
            
            //Implicit casting - otomatik dönüşüm
            //char ->int ->long ->float  ->double

            //explicit casting -manuel
            //double ->float ->long ->int ->char

            Console.WriteLine("Implicit Casting");
            int sayi = 9;
            double kesirlisayi = sayi;//int den double a otomatik dönüşüm
       
            Console.WriteLine(sayi1);
            Console.WriteLine(kesirlisayi);
            Console.WriteLine();
            //
            Console.WriteLine("Explicit Casting");
            double kesirlisayi2 = 18.2;
            int tamsayi = (int)kesirlisayi2;//manuel dönüştürme,soldan kırmızı butona basarak cast ile int yazabilirsin 

            Console.WriteLine(tamsayi);
            Console.WriteLine(kesirlisayi2);
            Console.WriteLine();

            // diğer tür dönüştürme yöntemleri ,
            // convert .toboolean convert.todouble convert.tositring convert.toınt32 int convert.toınt64 long

            int tamsayi2 = 12;
            double kesirlisayi3 = 5.23;
            bool islemsonuc = true;
            Console.WriteLine(Convert.ToString(tamsayi2));//convert int to string
            Console.WriteLine(Convert.ToDouble(tamsayi2));// convert int to double
            Console.WriteLine(Convert.ToInt32(kesirlisayi3));//convert double to int 
            Console.WriteLine(Convert.ToString(islemsonuc));//convert bool string 



            Console.Read();

        }
    }
}
