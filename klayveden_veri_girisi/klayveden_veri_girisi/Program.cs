using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klayveden_veri_girisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı yazınız");
            string ad;
            ad = Console.ReadLine();
            Console.WriteLine("Hoş geldiniz " + ad);
            Console.ReadLine();
        }
    }
}
