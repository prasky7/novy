using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podminky_6a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo v rozmezí 10-20:");
            int a = int.Parse(Console.ReadLine());
            if ((a >= 10) && (a <= 20))
                Console.WriteLine("Zadal jsi správně");
            else
                Console.WriteLine("Zadal jsi špatně");
            Console.ReadKey();
        }
    }
}
