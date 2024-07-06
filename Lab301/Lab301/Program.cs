using System;

namespace Lab301
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input exam score : ");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (S >= 50)
            {
                Console.WriteLine("The result is PASS");
            }
            else
            {
                Console.WriteLine("The result is FAIL");
            }
            //Console.WriteLine(S >= 50 ? "The result is PASS" : "The resuls FAIL");
            Console.ReadKey(); 
        }
    }
}
