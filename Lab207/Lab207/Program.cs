using System;

namespace Lab207
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double Fmin = 378, hour = Fmin / 60, Smin = Fmin % 60;
            Console.WriteLine("All minutes is {0}", Fmin);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\tTime is {0:00} hour {1} minute", hour, Smin);
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}
