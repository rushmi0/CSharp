using System;

namespace Lab1001
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a message : ");
            string message = Console.ReadLine();
            Console.WriteLine("MESSAGE IN UPPER CASE = {0}", message.ToUpper());
            Console.WriteLine("MESSAGE IN UPPER CASE = {0}", message.ToLower());
            Console.WriteLine("LENGTH OF MESSAGE = {0}", message.ToLower());
            Console.ReadKey();

        }
    }
}
