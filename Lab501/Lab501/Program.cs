using System;

namespace Lab501
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int num = 0, sum = 0;
            int Rsum = 0;

            for (int i = 1; i >= 0; i++)
            {
                Console.Write("Input number {0} : ", i);
                sum = int.Parse(Console.ReadLine());
                if (sum == 0)
                {
                    break;
                }

                num = num + 1;
                Rsum = Rsum + sum;

            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Sum of {0} number is {1}", num, Rsum);
            Console.ReadKey();
        }
    }
}
