using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bayanganhewan
{
    class Program
    {
        static void Main(string[] args)
        {
            burung_hantu hantu = new burung_hantu();
            burung_dara dara = new burung_dara();
            burung_merpati merpati = new burung_merpati();

            hantu.eat();
            dara.eat();
            merpati.eat();
            Console.ReadLine();
        }
    }
}
