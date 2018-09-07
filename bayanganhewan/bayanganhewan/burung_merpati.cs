using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bayanganhewan
{
    class burung_merpati : burung_hantu
    {
        public  void eat()//Override untuk dibaaawah induk
        {
            Console.WriteLine("Makanan Burung Merpati Adalah Buah");
        }
    }
}
