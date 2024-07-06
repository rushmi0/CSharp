using System;

namespace Example403
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = 0, num = 0;
            
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Input number {0} : ", i);
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            int avg = sum / 5;
            Console.WriteLine();
            Console.Write("Summary of all number is {0:n}\n", sum);


            Console.Write("Average of all number is {0:n}", avg);
            Console.ReadKey();
        }
    }
}
