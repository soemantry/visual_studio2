using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asik
{
    class Program
    {
        static void Main(string[] args)
        {
            mobil Avanza = new mobil();
            Avanza.on();
            Avanza.klakson();
            Console.ReadLine();
        }
    }
}
