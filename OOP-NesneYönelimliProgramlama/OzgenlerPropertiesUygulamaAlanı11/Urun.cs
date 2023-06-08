using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzgenlerPropertiesUygulamaAlanı11
{
      class Urun
    {
        public string urunAdi;

        private double urunFiyatı;

        public double UrunFiyatı
        {
            get { return urunFiyatı; }
            set
            {
                if (value <= 0)
                {
                    urunFiyatı= 1;
                }
                else urunFiyatı= value; 
            }
        }


    }
}
