using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitungbidangdatar_induk
{
    class bidang_datar
    {
        persegi bilangan = new persegi();
        public double luas;
        public double keliling;
        public double panjang1;
        public double lebar1;
        public double sisi1;
     
        public virtual double  getluas1()//beda dengan public doublenya
             {

                return luas;
             }
          public virtual double getkeliling1()//ini juga beda dengan public doublenya
             {
                return keliling;
            }
        public virtual  double getsisi()
        {
            return sisi1;
        }
        public virtual  double panjang()
        {
            return panjang1;
        }

        public virtual  double lebar()
        {
            return lebar1;
        }
    }
}
