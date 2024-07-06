using System;

namespace Lab1105
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Input number {0} : ", i+1);
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            ShowEven(number);
            ShowOdd(number);
            Console.ReadKey();
        }

        static void ShowEven(int[] num)
        {
            Console.WriteLine("List of Even number");
            Console.WriteLine("---------------------------------");
            foreach (int _num in num)
            {
                if (_num % 2 == 0)
                {
                    Console.Write("{0}", _num);
                }
            }
            Console.WriteLine();
        }

        static void ShowOdd(int[] num)
        {
            Console.WriteLine();
            Console.WriteLine("List of Odd number");
            Console.WriteLine("--------------------------------");
            foreach (int _num in num)
            {
                if (_num % 2 != 0)
                {
                    Console.Write("{0}", _num);
                }
            }

        }
    }
}
