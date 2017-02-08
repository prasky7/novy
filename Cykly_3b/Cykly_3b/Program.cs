using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Malá násobilka pomocí dvou cyklů:");
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                    Console.Write("{0} ", (i * j).ToString().PadLeft(3));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
