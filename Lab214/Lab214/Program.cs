using System;

namespace Lab214
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input number in variable 'A' : ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Input number in variable 'B' : ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            int A3 = A + B;  // int tempA = A;
            A = A3 - A;      //A = B;
            B = A3 - B;      //B = tempA;
            Console.WriteLine("After swap two numbers!!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("The number in variable 'A' is {0}", A);
            Console.WriteLine("The number in variable 'B' is {0}", B);
            Console.ReadKey();
        }
    }
}
