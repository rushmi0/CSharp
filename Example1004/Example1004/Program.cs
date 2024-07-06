using System;

namespace Example1004
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("How many number to input : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            InputAndSum(number);
            Console.ReadKey();
        }

        static void FindAverage(double sum, int num)
        {
            Console.WriteLine("Average is {0:f}", sum / num);
        }

        static void InputAndSum(int num)
        {
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Input number {0} : ", i);
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of {0} number is {1:f}", num, sum);
            FindAverage(sum, num);
        }
    }
}
