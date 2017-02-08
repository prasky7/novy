using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mocninátor");
            Console.WriteLine("==========");
            Console.WriteLine("Zadejte základ mocniny: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte exponent: ");
            int n = int.Parse(Console.ReadLine());

            int vysledek = a;
            for (int i = 0; i < (n - 1); i++)
                vysledek = vysledek * a;

            Console.WriteLine("Výsledek: {0}", vysledek);
            Console.WriteLine("Děkuji za použití mocninátoru");
            Console.ReadKey();
        }
    }
}
