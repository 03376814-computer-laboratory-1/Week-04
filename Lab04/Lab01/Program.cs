using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter value 1 :");
                int val1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter value 2 :");
                int val2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Answer = " + (val1 + val2));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
        }
    }
}