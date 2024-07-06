using System;

namespace Lab212
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input employee salary : ");
            double es = double.Parse(Console.ReadLine());
            double Ses = es * 3 / 100, Tes = es * 4 / 100, tatal = es - Ses - Tes;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Employee salary\t\t{0:f}", es);
            Console.WriteLine("Social Security\t\t{0:f}", Ses);
            Console.WriteLine("Tax            \t\t{0:f}", Tes);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Get salary     \t\t{0:f}", tatal);
            Console.ReadKey();
        }
    }
}
