using System;

namespace Lab401
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input value of N : ");
            int N = int.Parse(Console.ReadLine());

            while (N < 2)
            {
                Console.Write("Input value of N, again : ");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int x = 1;
            do
            {
                Console.Write(" {0} ", x);
                x++;
            }
            while (x <= N);

            Console.ReadKey();
        }
    }
}
