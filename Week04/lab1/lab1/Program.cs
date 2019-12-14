using System;


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (float i = 0; i < Math.PI * 2.0F; i += 0.3F)
            {
                Console.WriteLine("The sine of {0,10:F} = {1,-10:F6}" + spaces(Math.Sin(i)) + "*", i, Math.Sin(i));
            }
        }
        private static string spaces(double val)
        {
            string SpaceString = new String(' ', ((int)(val * 10.0)) + 10);
            return SpaceString;


        }
    }
}
