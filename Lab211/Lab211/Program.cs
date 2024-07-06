using System;

namespace Lab211
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input radius :");
            double r = double.Parse(Console.ReadLine());
            double CA = Math.PI * (r * r), CF = 2 * (Math.PI * r), VR = (4 / 3) * (Math.PI * (r * r * r));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Circle area   = {0:f3}", CA);
            Console.WriteLine("Circumference = {0:f3}", CF);
            Console.WriteLine("Volume round  = {0:f3}", VR);
            Console.ReadKey();
        }
    }
}
