using System;

namespace Lab403
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input value of N : ");
            int N = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            while (N < 2)
            {
                Console.Write("Input value of N, again : ");
                N = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                }

                if (!(i % 2 == 0))
                {
                    sum2 = sum2 + i;
                }
            }
            Console.WriteLine("Sum of all even number between 1 to {0} is {0:N}", sum1);
            Console.WriteLine("Sum of all odd  number between 1 to {0} is {0:N}", sum2);
            Console.ReadKey();
        }
    }
}
