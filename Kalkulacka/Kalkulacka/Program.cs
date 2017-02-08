using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v kalkulačce");
            Console.WriteLine("Zadejte první číslo");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo");
            float b = float.Parse(Console.ReadLine());
            float soucet = a + b;
            float rozdil = a - b;
            float soucin = a * b;
            float podil = a / b;
            Console.WriteLine("Součet " + soucet);
            Console.WriteLine("Rozdíl " + rozdil);
            Console.WriteLine("Součin " + soucin);
            Console.WriteLine("Podíl " + podil);
            Console.WriteLine("Děkuji za použití kalkulačky, aplikaci ukončíte libovolnou klávesou");
            Console.ReadKey();
        }
    }
}
