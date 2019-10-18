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
            
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            int id = Convert.ToInt32(Console.ReadLine());
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("name :"+name);
            Console.WriteLine("lastname :"+lastname);
            Console.WriteLine("id :"+id);
            Console.WriteLine("gpa :"+gpa);
            Console.ReadKey();
        }
    }
}