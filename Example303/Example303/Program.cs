using System;

namespace Example303
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
                Console.WriteLine("{0} is positive number.", num);
            }
            else if (num < 0)
            {
                Console.WriteLine("{0} is negative number.", num);
            }
            else
            {
                Console.WriteLine("{0} is zero number.", num);
            }
            Console.ReadKey();
        }
    }
}
