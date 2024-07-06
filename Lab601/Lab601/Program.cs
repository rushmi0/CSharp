using System;

namespace Lab601
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
            Console.WriteLine("Elements  in Array");
            Console.WriteLine("------------------");

            foreach (int _num in num)
            {
                Console.Write("{0} ", _num);
            }
            Console.ReadKey();
        }
    }
}
