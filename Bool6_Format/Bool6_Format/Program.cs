using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool6_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            /* složitější řešení */
            /* string s = string.Format("Když sečteme {0} a {1}, dostaneme {2}", a, b, c); */
            Console.WriteLine("Když sečteme {0} a {1}, dostaneme {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
