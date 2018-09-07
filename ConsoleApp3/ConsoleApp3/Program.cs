using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            float panjang, lebar, luas, keliling;
            Console.WriteLine("Kalkulator penghitung luas Persegi Panjang");
            Console.Write("Masukan Panjang  ");
            panjang = float.Parse(Console.ReadLine());
            Console.Write("Masukan lebar : ");
            lebar = float.Parse(Console.ReadLine());
            luas = panjang * lebar;
            Keliling = 2 * panjang + 2 * lebar;
            Console.WriteLine("Jadi luasnya adalah" + luas + " dan kelilingnya adalah" + Keliling);
            Console.ReadLine();
        }
    }
}
