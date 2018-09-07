using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Masukan Nilai alas : ");
            int alas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nilai tinggi : ");
            int tinggi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nilai sisi Kanan : ");
            int sisiKanan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nilai sisi Kiri : ");
            int sisiKiri = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("Luas Segitiga : {0}", +Convert.ToDouble(alas * tinggi) / Convert.ToDouble(2)+" Cm");
            Console.WriteLine("Keliling Segitiga : {0}", sisiKanan + sisiKiri + alas+" Cm");
            Console.ReadLine();
        }
    }
}
