using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array1 = new int[10];
            double z = 6, r = 2, n,k;
            for (int i = 0; i < 10; i++)
                {
                z = z + z;
                n = z * r;
                Console.WriteLine(n);
                k = Math.Max(n,n);
                
                Console.WriteLine(k);
            }
            
            Console.ReadLine();       
            }
        }
    }

    

