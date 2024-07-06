using System;

namespace Lab203
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num1 = 1000, num2 = 2010, num3 = 145000, num4 = 125.25;
            Console.WriteLine("Number 1 = {0:f3}", num1);
            Console.WriteLine("Number 2 = {0:f3}", num2);
            Console.WriteLine("Number 3 = {0:n1}", num3);
            Console.WriteLine("Number 4 = {0:f0}", num4);
            Console.ReadKey();
        }
    }
}
