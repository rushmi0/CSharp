using System;

namespace Lab502
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number in rage 2 - 12 : ");
            int num = int.Parse(Console.ReadLine());

            while (num < 2 || num > 12)
            {
                Console.Write("The number out of range! Input again : ");
                num = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
            }

            Console.ReadKey();
        }
    }
}
