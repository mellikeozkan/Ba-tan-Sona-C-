using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongulerde_karar_yapisi
{ // 1-20 ARASINDAKİ ÇİFT SAYILARI YAZDIRMA 
    class Program
    {
        static void Main(string[] args)

        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
