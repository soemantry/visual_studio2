using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contoh_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balaapan akan dimulai dalam .... ");
            int a = 27;
            while (a> 0)
            {
                Console.WriteLine(a + " ");
                a/=3;
                

            }
            Console.WriteLine("mulai..");
            Console.ReadKey();
        }
    }
}
