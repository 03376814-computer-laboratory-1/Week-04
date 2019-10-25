using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Value\tSquared\tCubed");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
        }
    }
}