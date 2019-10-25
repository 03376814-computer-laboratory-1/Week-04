using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine(randomNumber);
            int x = Convert.ToInt32(Console.ReadLine());
            bool y = randomNumber == x;
            Console.WriteLine("{0}", y);
            Console.WriteLine(y);
            Console.ReadKey();

            Console.WriteLine($"Number random : {randomNumber}");


        }
    }
}
