using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swicht_case
{   // BİRDEN FAZLA KOŞUL OLDUĞUNDA KULLANILIR.MEYVE İSİMLERİ KARIŞILIĞINI BULSUN .
    class Program
    {
        static void Main(string[] args)
        {
            string meyve;
            Console.Write("bir meyve adı giriniz:");
           meyve= Console.ReadLine();

            
            switch (meyve)
            {
                case "elma":Console.Write("apple"); break;
                case "muz": Console.Write("banana"); break;
                case "kavun": Console.Write("melon"); break;
                case "domates": Console.Write("tometo"); break;
                default:Console.Write("bulunamadı");break;



            }
            Console.ReadLine();
        }
    }
}
