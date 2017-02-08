using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool3
{
    class Program
    {
        static void Main(string[] args)
        {
            string konfig = "Fullscreen shaDows autosave";
            konfig = konfig.ToLower();
            Console.WriteLine("Poběží hra ve fullscreenu?");
            Console.WriteLine(konfig.Contains("fullscreen"));
            Console.WriteLine("Budou zapnuté stíny?");
            Console.WriteLine(konfig.Contains("shadows"));
            Console.WriteLine("Přeje si hráč vypnout zvuk?");
            Console.WriteLine(konfig.Contains("nosound"));
            Console.WriteLine("Přeje si hráč hru automaticky ukládat?");
            Console.WriteLine(konfig.Contains("autosave"));
            Console.ReadKey();
        }
    }
}
