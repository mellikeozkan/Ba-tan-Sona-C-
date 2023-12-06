using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//    SINAVDALARIN ORTALAMASI 50 VE ÜSÜT OLURSA GECSİN DEĞİLSE KALSIN 
namespace karar_yapilari_iki
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, ort;
            string durum;
            Console.Write("sınav 1 notunu  giriniz =");
            s1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Sınav 2 notunu giriniz =");
            s2 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2) / 2;
          

            if (ort>=50)
            {
                durum = "geçti";


            }
             else
            {
                durum = "kaldı";

            }
            Console.WriteLine("öğrenci sınav durumu " + durum);
            Console.ReadLine();


        }
    }
}
