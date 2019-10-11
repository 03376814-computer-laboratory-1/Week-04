using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random A = new Random();
                int num, numfromRandom;
                bool ass;
                string m = "more than", n = "less than";


                Console.WriteLine("Input your number between 0-9");
                num = int.Parse(Console.ReadLine());
                numfromRandom = A.Next(0, 9);

                ass = true;
                if (numfromRandom < num)
                {


                    Console.WriteLine("your input is {0} random number", m);
                }
                else
                {
                    Console.WriteLine("Random number is greater than yours");
                }
                
            }
            catch
            {
                Console.WriteLine("Error noob");
            }
            finally
            {
                Console.WriteLine("Ruk Arjan mak mak");
            }
              
            

        }
    }
}
