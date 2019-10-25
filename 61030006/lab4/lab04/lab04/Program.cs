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
            bool A, B, Y;
            Console.WriteLine("      Y = A AND B");
            Console.WriteLine("-----------------------");
            Console.WriteLine("   A      B\t|  Y");
            Console.WriteLine("-----------------------");
            A = false; B = false; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
            A = false; B = true; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
            A = true; B = false; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
            A = true; B = true; Y = A & B;
            Console.WriteLine(" {0}\t{1}\t| {2}", A, B, Y);
            Console.WriteLine("-----------------------");
        }
    }
}