using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coklu__if_yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 , s2, s3;
            int ortalama;
            string durum;

            Console.Write("sınav 1 girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sınav 2 girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sınav 3 girin:");
            s3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (s1 + s2 + s3) / 3;

           if (ortalama <= 49)
            {
                durum = "vasat";
                Console.Write(durum);
            }
            if (ortalama > 49 && ortalama <= 70)
            {
                durum = "iyi";
                Console.Write(durum);
            }

            if (ortalama > 70)
            {
                durum = "çok iyi";
                Console.Write(durum);
            }
            Console.ReadLine();
        }
    }
}
