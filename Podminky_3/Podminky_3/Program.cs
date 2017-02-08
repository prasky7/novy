using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podminky_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej nějaké číslo, ze kterého spočítám odmocninu:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Zadal jsi číslo větší než 0, to znamená, že ho mohu odmocnit!");
                double o = Math.Sqrt(a);
                Console.WriteLine("Odmocnina z čísla " + a + " je " + o);
            }
            Console.WriteLine("Děkuji za zadání");
            Console.ReadKey();
        }
    }
}
