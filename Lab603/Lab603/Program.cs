using System;

namespace Lab603
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Input number {0} : ", i + 1);
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Elements of Eeven number = ");
            foreach (int _num in num)
            {
                if (_num % 2 == 0)
                {
                    Console.Write("{0} ", _num);
                }

            }
            Console.WriteLine();
            Console.Write("Elements of Odd number = ");
            foreach (int _num in num)
            {
                if (_num % 2 != 0)
                {
                    Console.Write("{0} ", _num);
                }
                Console.ReadKey();
            }
        }
    }
}
