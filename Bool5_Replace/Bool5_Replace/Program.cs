using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool5_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Java je nejlepší";
            s = s.Replace("Java", "C#");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
