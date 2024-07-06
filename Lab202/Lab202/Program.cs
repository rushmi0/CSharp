using System;

namespace Lab202
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 252, num2 = 147, num3 = 368;
            float sum1 = num1 + num2 + num3;
            double ave = sum1 / 3;

            Console.WriteLine("Number 1 = {0,1}", num1);
            Console.WriteLine("Number 2 = {0,1}", num2);
            Console.WriteLine("Number 3 = {0,1}", num3);
            Console.WriteLine("Summary of {0,1}, {1} and {2} is {3}", num1, num2, num3, sum1);
            Console.WriteLine("Average is {0,1:N}", ave);

            Console.ReadKey();
        }
    }
}
