using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_dongusu //ŞART SAĞLANDIĞI SÜRECE 
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
            while (sayi <= 10)
            {
                Console.WriteLine(sayi + "-" +"merhaba dünya ");
                sayi++;

            }
            Console.ReadLine();

        }
    }
}
