using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//   ŞİFRE KONROLÜ 
namespace karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            string sifre;
            Console.Write("Lütfen şifre giriniz:");
            sifre = Console.ReadLine();

            if (sifre == "abc") 
            {
                Console.Write("Şifre Başarılı Sisteme Hoş Geldiniz");
            }

            else
            {
                Console.Write("şifre başarısız tekrar deneyiniz");
            }
            Console.ReadLine();
        }
    }
}
