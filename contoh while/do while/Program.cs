using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balaapan akan dimulai dalam .... ");
            int hitung = 10;
            do
            {
                Console.WriteLine(hitung + ".....");
                hitung--;
            }
            while (hitung > 0);
            Console.WriteLine("mulai..");
            Console.ReadKey();
        }
    }
}
