using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podminky_6b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo v rozmezí 10-20 nebo 30-40:");
            int a = int.Parse(Console.ReadLine());
            if (((a >= 10) && (a <= 20)) || ((a >= 30) && (a <= 40)))
                Console.WriteLine("Zadal jsi správně");
            else
                Console.WriteLine("Zadal jsi špatně");
            Console.ReadKey();
        }
    }
}
