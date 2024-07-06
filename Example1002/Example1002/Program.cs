using System;

namespace Example1002
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FindPowOfTwo();
            Console.ReadKey();
        }

        static void FindPowOfTwo()
        {
            Console.Write("Input an exponent : ");
            int exponent = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Answer is {0}", Math.Pow(2, exponent));
        }
    }
}
