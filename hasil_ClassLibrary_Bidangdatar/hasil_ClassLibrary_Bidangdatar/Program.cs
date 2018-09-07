using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_bidanngdaatar_classLibrary;
namespace hasil_ClassLibrary_Bidangdatar
{
    class Program
    {
        static void Main(string[] args)
        {
            bidangdatar ok = new bidangdatar();
            Console.Write("Masukan Nilai 1 = "); 
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nilai 2 = "); 
           int  b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasil luas Persegi Adalah " + ok.kotak(a));
            Console.WriteLine("Hasil luas Persegi Panjang Adalah " + ok.persegiPanjang(a, b));
            Console.WriteLine("Hasil luas Segitiga  Adalah " + ok .segitiga(a, b));
         

            Console.ReadLine();

        }
    }
}
