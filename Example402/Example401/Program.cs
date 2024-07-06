using System;

namespace Example401
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Input value of N : ");
            int N = int.Parse(Console.ReadLine());

            while (N <= 1)
            {
                Console.WriteLine("You number < 1");
                Console.Write("Input value of N : ");
                N = int.Parse(Console.ReadLine());

            }

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine();
            Console.WriteLine("Summary of 1 - {0} is {1:N}", N, sum);
            Console.ReadKey();
        }
    }
}
