using System;

namespace Lab602
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] num = new int[7];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Input a number index {0} : ", i);
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Elements in Array (Reverse)");
            Console.WriteLine("------------------");

            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", num[i]);
            }
            Console.ReadKey();
        }
    }
}
