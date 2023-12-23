using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarda_parametre_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            void kisiBilgi(string ad,string soyad,string sehir)
            {
                Console.WriteLine(ad);
                Console.WriteLine(soyad);
                Console.WriteLine(sehir);
            }

            kisiBilgi("Melike ", "Özkan", "Osmaniye");
            Console.ReadLine();



        }
    }
}
