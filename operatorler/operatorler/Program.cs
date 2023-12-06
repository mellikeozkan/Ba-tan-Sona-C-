using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  // KARAR YAPILARINDA VE SEMBOLÜ KULLANMA ŞİFRE VE KULLANICI ADI GİRİŞİ
namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            string  kullanici, sifre;
            
            Console.Write("kullanıcı adı giriniz =");
            kullanici = Console.ReadLine();
            Console.Write("şifre adı giriniz =");
            sifre =Console.ReadLine();

            if (kullanici == "melike" && sifre ==" 123"){

                Console.Write("giriş başarılı");

            }
             else
            {
                Console.Write("giriş başarısız ");
            }

            Console.ReadLine();
        }

    }
}
