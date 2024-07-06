using System;

namespace Lab1101
{
    class MainClass
    {
        public static void Main(string[] args)
        {
             /*int answer = Summation();
            Console.WriteLine("The answer of summation is {0}", answer );*/
            Console.WriteLine("The answer of summation is {0}", Summation());
            Console.ReadKey();
        }

        static int Summation()
        {
            Console.Write("Input a number : ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
