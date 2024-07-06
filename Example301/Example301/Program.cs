using System;

namespace Example301
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num > 0)
            {
                Console.WriteLine("This is positive number.");
            }

            Console.WriteLine("You input number = {0}", num);
            Console.ReadKey();
        }
    }
}
