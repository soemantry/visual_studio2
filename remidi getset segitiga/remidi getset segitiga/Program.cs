using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remidi_getset_segitiga
{
    class Program 
    {
        static void Main(string[] args) 
        {  

            
            getset_segitiga sgta = new getset_segitiga();

          
            

            Console.Write("Masukan Alas : ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Tinggi : ");
            double t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Sisi Kanan : ");
            double s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan  Sisi Kiri : ");
            double i = Convert.ToInt32(Console.ReadLine());


           double nalas = sgta.setalas(a);
           double alas = sgta.getalas();
           double ntinggi = sgta.setinggi(t);
           double  tinggi = sgta.gettinggi();
           double nskn = sgta.setskn(s);
           double skn = sgta.getskn();
           double nski1 = sgta.setski(i);
           double ski = sgta.getski();

            Console.Write("Luasnya Adalah  :  "+ (alas*tinggi)/2);
            Console.ReadLine();
            


        }
    }
}

