using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                const double lightSpeed = 186000d;   // miles per second
                Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
                const double mileTokm = 1.609344;
                Console.WriteLine("Light speed = {0} km Per second", lightSpeed * mileTokm);
                const double SunToEarthDistance = 93000000d;  // miles
                Console.WriteLine("SunToEarthDistance = {0} km", SunToEarthDistance * mileTokm);
                double SunToEarthTimeOfLight = SunToEarthDistance / lightSpeed;  // miles
                Console.WriteLine("SunToEarthTimeOfLight = {0} seconds", SunToEarthTimeOfLight);
                Console.WriteLine("SunToEarthTimeOfLight = {0} minutes", SunToEarthTimeOfLight / 60d);

            }
        }
    }
}
