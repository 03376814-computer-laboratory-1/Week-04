using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameStudentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int a,b,c;
            Console.WriteLine("Prees key yourname");
            Name=Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Press key your ID");
            a =int.Parse (Console.ReadLine());

            Console.WriteLine("Press key your GPA");
            b = int.Parse(Console.ReadLine());
            Console.ReadKey();



        }
    }
}
