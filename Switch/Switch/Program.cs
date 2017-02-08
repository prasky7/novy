using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v kalkulačce");
            Console.WriteLine("Zadejte první číslo:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Zvolte si operaci:");
            Console.WriteLine("1 - sčítání");
            Console.WriteLine("2 - odčítání");
            Console.WriteLine("3 - násobení");
            Console.WriteLine("4 - dělení");
            int volba = int.Parse(Console.ReadLine());
            float vysledek = 0;
            if (volba == 1)
                vysledek = a + b;
            else
            if (volba == 2)
                vysledek = a - b;
            else
            if (volba == 3)
                vysledek = a * b;
            else
            if (volba == 4)
                vysledek = a / b;
            if ((volba > 0) && (volba < 5))
                Console.WriteLine("Výsledek: {0}", vysledek);
            else
                Console.WriteLine("Neplatná volba");
            Console.WriteLine("Děkuji za použití kalkulačky, aplikaci ukončíte libovolnou klávesou.");
            Console.ReadKey();
        }
    }
}
