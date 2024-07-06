using System;

namespace Lab1103
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a message : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Lenth of message = {0}", name.Length);
            Console.WriteLine("Number of Upper-case = {0}", CountSpacebar(name));
            Console.WriteLine("Number of Lower-case = {0}", CountLower(name));
            Console.ReadKey();
        }

        static int CountSpacebar(string msg)
        {
            int sum = 0;
            foreach (int num in msg)
            {
                if (num == ' ')
                {
                    sum++;
                }
            }
            return sum;
        }

        static int CountUpper(string msg)
        {
            int sum = 0;
            foreach (int num in msg)
            {
                if (num >= 97 && num <= 122)
                {
                    sum++;
                }
            }
            return sum;
        }

        static int CountLower(string msg)
        {
            int sum = 0;
            foreach (int num in msg)
            {
                if (num >= 65 && num <= 90)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
