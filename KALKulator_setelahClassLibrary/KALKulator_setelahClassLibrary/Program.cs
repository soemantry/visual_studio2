using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kalkulaotr_classLibrary;

namespace KALKulator_setelahClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            menghitung hitung1 = new menghitung();
            Console.Write("masukan angka a = "); int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukan angka a = "); int b;
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasil Tambah Adalah "+hitung1.tambah(a,b));
            Console.WriteLine("Hasil Kurang Adalah "+ hitung1.kurang(a,b));
            Console.WriteLine("Hasil Baginya Adalah "+ hitung1.bagi(a,b));
            Console.WriteLine("Hasil Kalinya Adalah "+ hitung1.kali(a,b));

            Console.ReadLine();
        }
    }
}
