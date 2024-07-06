using System;

namespace Lab305
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (num1 > num2)
            {
                Console.WriteLine("First number ({0}) is greater that Second number ({1})", num1, num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("First number ({0}) is less that Second number ({1})", num1, num2);
            }
            else
            {
                Console.WriteLine("First number ({0}) is equal that Second number ({1})", num1, num2);
            }

            Console.ReadKey();
        }
    }
}
