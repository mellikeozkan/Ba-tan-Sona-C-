using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_sayisal_veri_girisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, sonuc;
            Console.Write("Sayı1=");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayi2=");
            s2 = Convert.ToInt32(Console.ReadLine());
          
            sonuc = s1 + s2;
            Console.WriteLine("toplam=" + sonuc);
            Console.ReadLine();

        }
    }
}
