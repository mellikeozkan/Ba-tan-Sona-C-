using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            Console.Write("karakter girişi yapınız;");
            karakter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(karakter);
            Console.ReadLine();


        }
    }
}
