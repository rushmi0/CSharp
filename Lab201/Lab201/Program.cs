using System;

namespace Lab201
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float num1 = 15, num2 = 47;
            Console.WriteLine("Summation       of {0} and {1} is {2}", num1, num2, (num1 + num2));
            Console.WriteLine("Subtraction     of {0} and {1} is {2}", num1, num2, (num1 - num2));
            Console.WriteLine("Multiplication  of {0} and {1} is {2}", num1, num2, (num1 * num2));
            Console.WriteLine("Division        of {0} and {1} is {2:N}", num1, num2, (num1 / num2));
            Console.ReadKey();
        }
    }
}
