using System;

namespace Lab607
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Input a message : ");
            string message = Console.ReadLine();

            int a = 0, e = 0, i = 0, o = 0, u = 0;
            foreach (char _message in message)
            {
                if (_message == 'A' || _message == 'a')
                {
                    a++;
                }
                if (_message == 'E' || _message == 'e')
                {
                    e++;
                }
                if
                (_message == 'I' || _message == 'i')
                {
                    i++;
                }
                if
                (_message == 'O' || _message == 'o')
                {
                    o++;
                }
                if
               (_message == 'U' || _message == 'u')
                {
                    u++;
                }
            }
            Console.WriteLine("The number of letter'A' is {0}", a);
            Console.WriteLine("The number of letter'E' is {0}", e);
            Console.WriteLine("The number of letter'I' is {0}", i);
            Console.WriteLine("The number of letter'O' is {0}", o);
            Console.WriteLine("The number of letter'U' is {0}", u);
            Console.ReadKey();
        }
    }
}
