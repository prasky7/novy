using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool4_Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte číslo");
            string s = Console.ReadLine();
            Console.WriteLine("Zadal jste text: " + s);
            Console.WriteLine("Text po funkci trim: " + s.Trim());
            int a = int.Parse(s);
            Console.WriteLine("Převedl jsem zadan text na číslo parsováním, zadal jste: " + a);
            Console.ReadKey();
        }
    }
}
