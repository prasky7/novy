using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zdvojnasobovac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo k zdvojnásobení:");
            string s = Console.ReadLine();
            int a = int.Parse(s); }
            a = a * 2;
            Console.WriteLine(a);
            Console.ReadKey(); ;
        }
    }
}
