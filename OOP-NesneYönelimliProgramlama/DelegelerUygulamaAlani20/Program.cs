using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegelerUygulamaAlani20
{
    class Vergiler
    {
        public double BruutOku()
        {
            Console.WriteLine("Brüt Gelirinizi Giriniz:");
            return Double.Parse(Console.ReadLine());//geriye veri girilmesini sağladık
        }

        public double GelirvergisiHesapla(double d)
        {
            if (d > 5000) return d * 0.40;
            else return d * 0.25;
        }
    }
    public delegate void BasitDelege();//delege tanımlaması
    public delegate void ParemetreliDelege(int a,int b);//paremeterli delege tanımlaması
   
    public class Program
    {
        static void Main(string[] args)
        {
            // Vergiler vergiler=new Vergiler();
            // Console.WriteLine("Ödeyeceğiniz vergi :" + vergiler.GelirvergisiHesapla(vergiler.BruutOku()));
            BasitDelege delege = new BasitDelege(Topla);
            delege();
            ParemetreliDelege paremetreliDelege = new ParemetreliDelege(Topla);//direk otomatikmen paremetreli metodu alacak 
            paremetreliDelege(120, 16);
            Console.ReadLine();
        }

        static void Topla()
        {
            Console.WriteLine("İşlem sonucu:" + (10 + 8));
        }
        static void Topla(int x,int y)
        {
            Console.WriteLine("İşlem sonucu:" + (x + y));
        }
    }
}
