using System;

namespace Example302
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            //Console.WriteLine("Both of number {0} equal.", num1 == num2 ? "are" : "are NOT");

            if (num1 == num2)
            {
                Console.WriteLine("Both of number are equal.");
            }
            else
            {
                Console.WriteLine("Both of number are NOT equal.");
            }

            Console.ReadKey();
        }
    }
}
