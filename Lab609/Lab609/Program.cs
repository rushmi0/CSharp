using System;

namespace Lab609
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string message = "";

            Console.Write("Input a message : ");
            message = Console.ReadLine();
            Console.Write("show in upper case = ");
            foreach (char letter in message)
            {
                if (letter >= 97 && letter <= 122)
                {
                    Console.Write("{0}", Convert.ToChar(letter - 32));
                }
                else
                {
                    Console.Write("{0}", letter);
                }
            }

            Console.ReadKey();
        }
    }
}
