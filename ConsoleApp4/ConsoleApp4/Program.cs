using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            float alas,tinggi,sisiKiri,sisiKanan, luas, Keliling;
            Console.WriteLine("Kalkulator penghitung luas dan keliling segitiga");
            Console.Write("Masukan Nama Anda :  ");
            nama = float.Parse(Console.ReadLine();

            Console.WriteLine("1. Segitiga");
            Console.Write("Masukan Alas     =  ");
            alas = float.Parse(Console.ReadLine());
            Console.Write("Masukan tinggi   =  ");
            tinggi = float.Parse(Console.ReadLine());
            Console.Write("Masukan sisiKanan = ");
            sisiKanan = float.Parse(Console.ReadLine());
            Console.Write("Masukan sisiKiri  = ");
            sisiKiri = float.Parse(Console.ReadLine());
            luas = alas * tinggi /2 ;
            Keliling = alas + sisiKiri + sisiKanan;
            Console.WriteLine("Jadi luasnya adalah " + luas + " dan kelilingnya adalah " + Keliling);
            Console.ReadKey();
            break; 
            float Panjang, Lebar, Luas, Keliling;
            Console.WriteLine("2. Persegi Panjang");
            Console.Write(" Masukan Panjang :  ");
            Panjang = float.Parse(Console.ReadLine());
            Console.Write("Masukan Lebar : ");
            Lebar = float.Parse(Console.ReadLine());
            Luas = Panjang * Lebar;
            Keliling = 2 * Panjang + 2 * Lebar;
            Console.WriteLine("Jadi, luasnya adalah" + Luas + " dan Kelilingnya adalah" + Keliling);
            Console.ReadKey();





        }
    }
}
