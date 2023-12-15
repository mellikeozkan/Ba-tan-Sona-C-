using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_dongusu
{  //BU DİZİLERİN SIRALI ŞEKİLDE EKRANA VERİLMESİDİR 
   //                                                 4 TÜRDEN OLUŞUR BUNLAR;               1- değişken türü      2 -değişken adı       3-in           4- dizi adı 
    class Program
    {
        static void Main(string[] args)
        {

            string[] sehirler = { "adana", "mersin", "osmaniye", "antalya", "kütahya" };

            {
                foreach (string x in sehirler) 
                Console.WriteLine(x);
            }

          
            
            Console.ReadLine();
        }
        

    }
}
