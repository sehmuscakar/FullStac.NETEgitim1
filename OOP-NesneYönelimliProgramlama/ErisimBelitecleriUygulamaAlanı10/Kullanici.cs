using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelitecleriUygulamaAlanı10
{
    public class Kullanici//Ana sınıflar sadece public ve internal erişim belirtecleri alabilir.
    {
        public string Adi;// Program class ında bu değişkene ulaşmak için string in önüne public ekledik, yoksa orada erişemiyoruz

        internal string Soyadi; // Bir diğer erişim yöntemi de string şu önüne internal yazmak,böylece aynı projede olduğu için bu değişkende 
        //ulaşılabilir hale geliyor

        private string Telefon;//Buradaki telefon değişkeni ise private yaptığımız için program class ında gelmez ama bu class da kullanabiliriz

        protected string Email; // bu email değişkenine de program cs den erişemeyiz protected yaptığımız için,bu sınıfta veya buradan miras alan bir 
        //sınıfta kullanabiliriz

        string sifre;

    }

    internal class Adres
    {
        private class sipris//Ana sınıf içerisinde private ve internal erişim belirteci alabilir sınıflar 
        {

        }
    }
}
