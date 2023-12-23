using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_ve_metotlar
{
    class Visitor
    {
        public int Id { get; set; }
        public  string  Name { get; set; } 
        public string  City { get; set; }

        void mesaj (string p)
        {
            Console.WriteLine(p);
            Console.ReadLine();
        }
      
         

    }
}
