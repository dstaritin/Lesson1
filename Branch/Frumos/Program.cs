using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frumos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Squares of numbers");
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} - {1}", i, i * i);
            }
        }
    }
}
