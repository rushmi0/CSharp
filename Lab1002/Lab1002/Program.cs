using System;

namespace Lab1002
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input our e-mail : ");
            string email = Console.ReadLine().ToLower();
            while (email.EndsWith("@hotmail.com") == false || email.Contains(" ") == true || email[0].Equals('@'))
            {
                Console.Write("Input our e-mail, again : ");
                email = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.WriteLine("Your e-mail is {0}", email.ToUpper());
            Console.ReadKey();

        }
    }
}
