using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDoiXung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Nhap so nguyen duong a: a = ");
                a = Convert.ToInt32(Console.ReadLine());
            }while(a <= 0);

            Console.WriteLine("\n" + a + " là số đối xứng?\t" + KiemTra.check(a));
        }
    }
}