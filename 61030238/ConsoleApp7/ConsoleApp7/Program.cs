using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (float i = -3; i < (Math.PI); i += 0.3F)
            {
                {
                    Console.WriteLine("The sine of {0,10:F} = {1,-10:F6}" + spaces(Math.Tan(i)) + "*", i, Math.Tan(i));
                }
            }
        }

        private static string spaces(double val)
        {
            string SpaceString;
            try
            {
                SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
            }
            catch (ArgumentException)
            {
                return " ";
            }
            return SpaceString;
        }
    }
}
