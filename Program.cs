using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite cjenu bez PDV-a");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Upisite cjenu sa PDV-om");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("PDV je " + (((y / x) -1 ) * 100) + " % ");
            Console.ReadKey();
        }
    }
}
