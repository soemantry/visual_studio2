using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mteri_erorIntString
{
    class Program
    {
        static void Main(string[] args)
        {

            try //menegecek tipe data ketika user memasukan,apakah memaskan angka atau huruf
            {
                Console.Write("masukan angka a = "); int a;
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("masukan angka a = "); int b;
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            catch (FormatException formatsalah)//mnggunakan  formatexception
            {
                Console.WriteLine("TERIMA KASIH "+formatsalah.Message);

                //throw;
                Console.ReadLine();
            }
           
            finally
            {
                Console.WriteLine("TERIMA KASIH");
                Console.ReadLine();
            }




        }
    }
}
