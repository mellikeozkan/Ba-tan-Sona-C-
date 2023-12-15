using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_dongusu_iki
{
    class Program
    {

        //  DİZİ İÇİNDEKİ 3 E BÖLÜNEN SAYILARIN HEPSİNİ YAZDIRAN DÖNGÜ YAPALIM 
        static void Main(string[] args)
        {
            int[] sayilar = { 28, 32, 89, 92, 48, 50, 21, 63 };
            

            
            foreach (int x in sayilar) 
            {  
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }


               
            }
               Console.ReadLine();
        }


    }
}
