using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongulerde_karar_yapisi_uc
{
    class Program  // 1 DE 10 A KADAR OLAN SAYILARIN TOPLAMI 
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
            }
            Console.Write(toplam);
            Console.ReadLine();
        }
    }
}
