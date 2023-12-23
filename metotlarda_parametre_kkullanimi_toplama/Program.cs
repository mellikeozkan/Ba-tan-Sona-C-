using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarda_parametre_kkullanimi_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            void topla(int s1,int s2)
            {
                int sonuc = s1 + s2;
                Console.WriteLine(sonuc);

            }
             topla(79,99);
            Console.ReadLine();

        }
    }
}
