using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balaapan akan dimulai dalam .... ");
          
            for(int hitung = 27 ; hitung > 0 ; hitung /=3 )
          
            {
                Console.WriteLine(hitung + ".....");
               
            }

            Console.WriteLine("mulai..");
            Console.ReadKey();
        }
    } 
}
