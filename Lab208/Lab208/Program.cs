using System;

namespace Lab208
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input number1 : ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Input number2 : ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Input number3 : ");
            float num3 = float.Parse(Console.ReadLine());

            float sum = num1 + num2 + num3, ave = sum / 3;

            Console.WriteLine("                                 ");
            Console.WriteLine("Summary of {0}, {1} and {2} is {3}", num1, num2, num3, sum);
            Console.WriteLine("Average is {0}", ave);

            Console.ReadKey();
        }
    }
}
