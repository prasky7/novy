using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool7_PadLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte vaše jméno");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Délka vašeho jména je: {0}", jmeno.Length);
            Console.ReadKey();
        }
    }
}
