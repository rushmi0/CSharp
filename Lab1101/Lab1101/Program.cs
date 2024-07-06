using System;

namespace Lab1101
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int number = int.Parse(Console.ReadLine());

            while (number < 2)
            {
                Console.Write("The number must greater than 1 only, Input again : ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Factorial of {0} is {1:n0}", number, Factorial(number));
            Console.ReadKey();
        }

        static int Factorial(int num)
        {
            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }

    }
}
