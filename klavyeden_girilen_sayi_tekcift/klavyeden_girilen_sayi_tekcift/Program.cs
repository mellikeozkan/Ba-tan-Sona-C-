using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_girilen_sayi_tekcift
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1,mod;
            string durum;

            Console.Write("Lütfen bir sayı giriniz :");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            mod = sayi1 % 2;

          if (mod == 0)
            {
                durum = "çift";
                Console.WriteLine(durum);

            }

            else
            {
                durum = "tek";
                Console.WriteLine(durum);
            }
            Console.ReadLine();
        }
    }
}
