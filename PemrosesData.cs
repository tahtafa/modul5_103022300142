using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300142
{
    class PemrosesData
    {

        public void DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
        {
            dynamic temp1 = data1;
            dynamic temp2 = data2;
            dynamic temp3 = data3;
            dynamic temp1maks = temp1;


            if (temp1maks < temp2)
            {
                temp1maks = temp2;
                Console.WriteLine("Nilai terbesar adalah " + temp2);
            }
            else if (temp3 > temp1maks)
            {
                temp1maks = temp3;
                Console.WriteLine("Nilai terbesar adalah " + temp3);
            }
            else {
                Console.WriteLine("nilai terbesar adalah " + temp1maks);
            }
        }


    }
}
