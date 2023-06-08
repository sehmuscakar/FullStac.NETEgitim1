using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulamaAlanı17
{

    //interface(arayüz) :soyut kavramlardır interfacede kalıtım implemantasyon denir ,imzalar buraya yazılır

    interface OrnekArayuz //erişim belirteci publictir zaten implemante dileceği için 
    {
        int MyProperty { get; set; } // bunda da erişim belirteci publictir
    }

    interface Idema
    {
        void Goster();//metot imzası oluşturduk,Interfacelerde sadece metot imzaları yer alır,metotlar bu interface den miiras alan class larda kullanılır
    }


    interface Inokta
    {
        //Özgenlerin imzaları 

        int x
        {
            get; set;
        }
        int y
        {
            get; set;
        }

    }

    //Inokta arayüzünü implement eden sınıfımız

    class Nokta : Inokta
    {

        //Alanlar fields
        private int _x { get; set; }
        private int _y { get; set; }

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }


    }


    interface icerebilecekleri : Idema// bu da class lardaki gibi kalıtım yani
    {

        //bir ımterface in içerebileceği özelikler
        //public int MyProperty {get;set;} bir interface içerisine prop tab tab ile propert eklersek başındaki public ifadesini kaldırmak zorundayız çünkü interfaceler erişim belirteci almaz 
        //daima publictir zaten 

        int Sayi { get; set; }//Interfaceler erişim belirteçsiz property leri barındırabilir

        //static int Sayi2 {get;set;}

        void MesajVer();//interfface ler netot imzalarını barındırabilir
                        //İçermedikleri
                        //string metin;İnterfaceler içerisinde değişken kullanılmaz
                        //interfaceler class lardaki kurucu metotları da kullanamaz

        int CikarmaYap(int sayi1, int sayi2);//interfaceler paremetreli metot imzası alabilir

        /*  int CikarmaYap(int sayi1,int sayi2) // interfacelerin içinde metotların içi doldurulmaz
          {
        return sayi1-sayi2; interfaceler içerisinde metotların yapacağı işler tanımlanmaz
          }
        */

    }

    class ArayuzKullanimi : icerebilecekleri
    {
        public int Sayi { get; set; }

        public int CikarmaYap(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public void Goster()
        {
            Console.WriteLine("İnterface de imzası tanımlanan yapacağı iş class da belirlenir");
        }

        public void MesajVer()
        {

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {



        }
    }

    interface ISinifGereksinimleri
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime CreateDate { get; set; }//kayıdın oluşturulma zamanı 
        DateTime changeTime { get; set; }//en son ne zaman değiştirildin

    }

    interface IVeritabanıIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();//bir tane kayıt getirmek 
        void GetAll();// çoklu kayıt getirmek
    }


    class Kategori:ISinifGereksinimleri, IVeritabanıIslemleri//bir sınıfa birden ffazla interfaceden kalıtım yapabiliyoruyz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime changeTime { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Urun : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime changeTime { get; set; }
    }

    class Marka : ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime changeTime { get; set; }
    }
}
