using System;

namespace Example603
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a message : ");
            string massage = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Length of  message = {0} ", massage.Length);
            Console.WriteLine("Fi = {0}", massage.[0]);
        }
    }
}
