using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgenlerPropertiesUygulamaAlanı11
{
    class kisi
    {
        private int yas;
        private string dogumyeri;
        private string meslek;

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }// soyadı çağırdığında get blogu çalışır soyadı değerini getirir.,soyada alnınına bir değer gönderdiğinde set blogu çalışıyor

        public bool Aktif { get; set; }

    }
}
