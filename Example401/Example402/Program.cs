using System;

namespace Example402
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N;

            do
            {

                Console.Write("Input value of N : ");
                N = int.Parse(Console.ReadLine());

            }
            while (N <= 1);

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Summary of 1 - {0} is {1:N}", N, sum);
            Console.ReadKey();
        }
    }
}
