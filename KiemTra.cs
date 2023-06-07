using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDoiXung
{
    internal class KiemTra

    {
        public static bool check(int a)
        {
            int a_cpy = a;
            int a_doiCho = 0;
            while(a_cpy > 0)
            {
                a_doiCho = a_doiCho * 10 + (a_cpy % 10);
                a_cpy /= 10;
            }
            return (a_doiCho == a)? true : false;
        }
    }
}