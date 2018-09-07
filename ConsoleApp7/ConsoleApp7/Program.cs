using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Masukan Sisi Persegi Panjang :   ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Luas Persegi Panjang adalah {0}", x*x);

           Console.ReadLine();
        }
    }
}
