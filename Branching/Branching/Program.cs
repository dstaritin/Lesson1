using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine("100 / 3 = {0}", i /= 3);

            double j = 100.0;
            Console.WriteLine("100.0 / 3.0 = {0:#.##}", j /= 3.0);
        }
    }
}
