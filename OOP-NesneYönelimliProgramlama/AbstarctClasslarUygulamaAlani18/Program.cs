using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClasslarUygulamaAlani18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database datebase = new Oracle();  //Database classından datebase nesnesini türetik ve Oracle sınıfını new liyoruz yani datebase nesnesi oracle sınıfından verileri alacak 
            datebase.Add();
            datebase.Delete();

            Database sql = new SqlServer();
            sql.Add();
            sql.Delete();

            Console.Read();

        }
    }

    abstract class Database//abstract classlarda hem imzayı yazabilirsin hemde imzanınınn içini doldurabilirsin,normal class larada kalıtım yapabilirsin 
    {
        //hem metot tanımlayabilirsin hemde metodun içini dolldurabilirsin 

        public void Add()
        {
            Console.WriteLine("Ekleme başarılı");
        }

        public abstract void Delete();//metot imzalarını oluştuurduk

        public abstract void Update();

        public abstract void Get();

    }

    class SqlServer : Database // kkalıtım yaptık abstrask  sinifi,implement ettik
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt Datebase dan silindi");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt Oracle dan silindi");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class MYsql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Kayıt Mysql den silindi");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
