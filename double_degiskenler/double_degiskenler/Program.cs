
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, s3;
            double ort;
            Console.Write("Sınav 1=");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sınav 2=");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sınav 3=");
            s3 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2+ s3)/3 ;
            Console.Write("Ortalama =" + ort);
            Console.ReadLine();
        }
    }
}
