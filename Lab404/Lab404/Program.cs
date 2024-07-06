using System;

namespace Lab404
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Input value of N : ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;

            while (N <= 0)
            {
                Console.Write("Input value of N, again : ");
                N = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 12; i++)
            {
                sum = i * N;
                Console.WriteLine("{0} x {1} = {2}", i, N, sum);
            }

            Console.ReadKey();
        }
    }
}
