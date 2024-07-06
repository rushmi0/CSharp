using System;

namespace Example1102
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The answer of summation is {0}", Summation(number));
            Console.ReadKey();
        }

        static int Summation(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
