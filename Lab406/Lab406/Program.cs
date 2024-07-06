using System;

namespace Lab406
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("How many number to input : ");
            int N = int.Parse(Console.ReadLine());


            int sum1 = 0, sum2 = 0;

            while (N < 1)
            {
                Console.Write("The number must more that 1, Input again : ");
                N = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Input number {0} : ", i);
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    sum1 = sum1 + 1;
                }
                else
                {
                    sum2 = sum2 + 1;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Even number have {0} from {1}", sum1, N);
            Console.WriteLine("Odd  number have {0} from {1}", sum2, N);
            Console.ReadKey();
        }
    }
}
