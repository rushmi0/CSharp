using System;

namespace Lab1004
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            while (num <= 1)
            {
                Console.Write("Input number, again : ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            sum(num);
            Factorial(num);
            Console.ReadKey();
        }

        static void sum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        static void Factorial(int num)
        {
            int fac = 1;
            for (int i = num; i >= 1; i--)
            {
                fac *= i;
            }
            Console.WriteLine("Factorial = {0:n0}", fac);
        }
    }
}
