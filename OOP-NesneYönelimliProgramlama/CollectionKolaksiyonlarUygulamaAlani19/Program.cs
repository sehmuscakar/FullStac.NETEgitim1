using System;
using System.Collections;//arraylist için eklendi
using System.Collections.Generic;
using System.Collections.Specialized;// StringCollection için eklendi alt kütüphane özeleştirilmiş 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionKolaksiyonlarUygulamaAlani19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizilerin gelişmiş hali kolleksiyonlar
            //  Ornek1();
            // Ornek2();
            // Ornek3();
            // Ornek4();
            // Ornek5();
            // Ornek6();
            //    Ornek7();
            //   Ornek8();
            // Ornek9();
            ListKullanimi();
            Console.Read();
        }

        static void Ornek1()
        {
            ArrayList arrayList= new ArrayList();//listemizi oluşturduk 
            arrayList.Add(13);//ekleme yapıyoruz 
            arrayList.Add(16);
            arrayList.Add(19);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList[1]);//arraydeki 1 indexi çağırdık 
        }

        static void Ornek2()
        {
            ArrayList arrayList = new ArrayList(); 
            arrayList.Add("İzmir");
            arrayList.Add("Ankara");
            arrayList.Add("İstanbul");
            Console.WriteLine("Sıralanmamış liste");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine(" A dan Z ye Sıralanmış Liste");
            arrayList.Sort();//sıralanmayı sağlıyor
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
            Console.WriteLine(" Z dan A ye Sıralanmış Liste");
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }


        }


        static void Ornek3()
        {
            //Koleksiyonlara farklı veri tiplerinden değerller atama
            int tamsayi = 14;
            double dabil = 10.4;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Başkent Ankara");
            arrayList.Add(tamsayi);
            arrayList.Add(dabil);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }


        }

        static void Ornek4()
        {
            StringCollection sc =new StringCollection();//eğer verilerin sadece string olacakssa bu yapıyı kullanman faydalı olacaktır.,daha verimli çalışır
            sc.Add("Ankara");
            sc.Add("İstanbul");
            sc.Add("İzmir");

            foreach(var item in sc)
            {
                Console.WriteLine(item);
            }
        }


        static void Ornek5()
        {
            StringDictionary stringDictionary=new StringDictionary();
            stringDictionary.Add("06", "Ankara");//keys,value değerleri
            stringDictionary.Add("34", "İstanbul");
            stringDictionary.Add("35", "İzmir");
            Console.WriteLine(stringDictionary["06"]);//06 ı key değeri valuesi Ankara
            foreach (var item in stringDictionary.Values)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stringDictionary.Keys)
            {
                Console.WriteLine(item);
            }

        }
        static void Ornek6()
        {
            Stack stack= new Stack();//stack lifo son giren ilk çıkar şeklinde ,stack sınıfı programlamada lıfo(last in first out) son giren ilk çıkar diye bilinen 
            //önemli bir yapıdır

            stack.Push("Ankara");// push eklemek için kulanılır 
            stack.Push("İstanbul");
            stack.Push("İzmir");

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());//stack in üstünden bir öğe çekmek için pop metodu kullanılır.
            }

        }

        static void Ornek7()
        {
            //Queue sinifi programlamada FIFO(first in first out,ilk giren ilk çıkar)diye bilinen yapısıdır.
            Queue queue= new Queue();
            queue.Enqueue("Ankara");//Enqueue veri eklemeye yarayan metot
            queue.Enqueue("İstanbul");
            queue.Enqueue("İzmir");
            while (queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());//Dequeue veri çekmeye yarayan metotur.
            }
        }




        static void Ornek8()
        {
            Hashtable hashtable=new Hashtable();//
            hashtable.Add(06, "Ankara");
            hashtable.Add(34, "İstanbul");
            hashtable.Add(35, "İzmir");

            Console.WriteLine("Anahtarlar");

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Değerler");

            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Arama yapmak için değeri girin:");
            int n=int.Parse(Console.ReadLine());// girilecek olan değeri string ten inte cevirdik ve int olan n değişkenine atadık
            Console.WriteLine(hashtable[n]);//ve hastableiçindeki değeri yazdırdık 

        }

        static void Ornek9()
        {
            Dictionary<string ,string> keyValuePairs=new Dictionary<string ,string>();
            keyValuePairs.Add("book", "kitap");//keys values
            keyValuePairs.Add("table", "masa");
            keyValuePairs.Add("camputer", "bilgisiyar");
            keyValuePairs.Add("laptop", "dizüstü");
            keyValuePairs.Add("tv", "televizyon");
            Console.WriteLine(keyValuePairs["table"]);

            Dictionary <int,string> keyValues=new Dictionary<int,string>();
            keyValues.Add(01, "Adana");
            keyValues.Add(06, "Ankara");
            keyValues.Add(18, "Çamkırı");
            keyValues.Add(34, "İstanbul");
            Console.WriteLine(keyValues[18]);

            foreach (var item in keyValues) 
            {
                Console.WriteLine("Anahtar:" + item.Key + " - Değer :" + item.Value);
            }

            Console.WriteLine(keyValuePairs.ContainsKey("gozluk"));//keylerde arama yapar true false değerlerini döndürür
            Console.WriteLine(keyValuePairs.ContainsKey("table"));

        }

        class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        static void ListKullanimi()
        {
            List<string> sehirler =new List<string>();// string tipi alan bir list sınıfı oluşturduuk ve sehirler nesnesini oluşturduk,T olarak string kullandık
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            Console.WriteLine(sehirler.Contains("Adana"));// arama yapıyor

            foreach (var item in sehirler) 
            {
                Console.WriteLine(item);
            }

            List<User> users= new List<User>();//List sınıfında T değerini User sınıfından verdik.
            users.Add(new User { Id=1, FirstName="şehmus",LastName="Çakar"});//biz burda User sınıfından propertylerine eriştik ve doldurduk new ledik user propertylerini yeni veriler girdik yani
            users.Add(new User { Id = 2, FirstName = "Metin", LastName = "Çakar" });
            users.Add(new User { Id = 3, FirstName = "Zehra", LastName = "Çakar" });


            //böylede propertlerin içini doldurabilirsin 
            List<User> Kullanicilar = new List<User>()
            { 
            new User { Id=1, FirstName="şehmus",LastName="Çakar"},
            new User  { Id = 2, FirstName = "Metin", LastName = "Çakar" },
            new User { Id = 3, FirstName = "Zehra", LastName = "Çakar" }
            };

            var yenikullanici = new User//User sınıfına yeni veriler giriyoruz 
            {
                Id=4,
                FirstName="Mehmet",
                LastName="Kaya"
            };
            Console.WriteLine(Kullanicilar.Contains(yenikullanici));//kullanıcılar nesnesi sayesinde User içinde arama yapacak  
            Kullanicilar.Add(yenikullanici);
            Kullanicilar.AddRange(new User[2]
            {
                new User{Id=1,FirstName="Ayşe",LastName="Demir"},
                new User{Id=2,FirstName="Helin",LastName="Çelik"},
            });
            Kullanicilar.AddRange(users);
            Console.WriteLine(Kullanicilar.Contains(yenikullanici));//Contains kayıtlar içinde arama yapıyor
            var index = Kullanicilar.LastIndexOf(yenikullanici);// Son girilen index numarasını gösterir
            Console.WriteLine("YneiKullanici son index numarası:" + index);

            var index2 = Kullanicilar.IndexOf(yenikullanici);// girilen index numarasını gösterir
            Console.WriteLine("YneiKullanici index numarası:" + index2);
            Kullanicilar.Add(yenikullanici);
            var sonindex = Kullanicilar.IndexOf(yenikullanici);
            Console.WriteLine("yeniKullanici son index numarası:" + sonindex);

            Kullanicilar.Insert(1, yenikullanici);//1 index numarsı 1 olana ekleme yapacak,listeye istediğimiz sıraya eleman ekleme insert ile 
            Kullanicilar.Remove(yenikullanici);// eklediğimiz elemanı sildik
            foreach (var item in Kullanicilar)
            {
                Console.WriteLine("Id: "+item.Id+" Adı: "+item.FirstName);//kullanıcılar isimlerini listeliyecek 
            }

            var count = Kullanicilar.Count;//kullanıcılar sayınını döndürecek
            Console.WriteLine($"kullanıcılar listesindeki eleman sayısı {count} adettir.");// c# taki diğer biz yazım kuralı
       
        
        }

    }
}
