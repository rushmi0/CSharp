using System;

namespace Example1003
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input an exponent : ");
            int exponent = int.Parse(Console.ReadLine());
            FindPowOfTwo(exponent);
            Console.ReadKey();
        }

        static void FindPowOfTwo(int exp)
        {

            Console.WriteLine();
            Console.WriteLine("Answer is {0}", Math.Pow(2, exp));
        }
    }
}
