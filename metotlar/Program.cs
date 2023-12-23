using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar




/* GERİYE DEĞER DÖNDÜREN VE DÖNDÜRMEYEN OLARAK İKİYE AYRILIR 
 AMACI KOD TEKRARI OLMAMASI 
 VOİD GERİ DÖNDÜRMEZ   VOİD METOT_İSİM()
 { 
... İŞLEMLER
    }

*/

{
    class Program
    {
        static void Main(string[] args)

        {
            void Yazdir()
            {
                Console.WriteLine("hoş geldiniz ");
                Console.WriteLine("ne kadar güzel  bir gün");
                
            }

            Console.WriteLine("merhaba melike hanım");
            Yazdir();
            Yazdir();
            Yazdir();  // NE KADAR YAZDIRIRSAN O KADAR ÇIKTI VERİR 

            Console.ReadLine();
        }
    }
}
