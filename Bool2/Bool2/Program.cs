using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Krokonosohroch";
            Console.WriteLine(s.StartsWith("krok"));
            Console.WriteLine(s.EndsWith("hroch"));
            Console.WriteLine(s.Contains("nos"));
            Console.WriteLine(s.Contains("roh"));
            Console.ReadKey();
        }
    }
}
