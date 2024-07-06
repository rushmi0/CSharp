using System;

namespace Lab205
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int id = 2013110305, sub = 7, subPone = 4500, subtni = 5000, total = (sub * subPone) + subtni;
            Console.WriteLine("STUDENT ID = {0}", id);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("ENROLLMENT {0,13} Subject. ({1} Baht/Subject)", sub, subPone);
            Console.WriteLine("TOTAL PRICE {0,15} Baht.", total);
            Console.ReadKey();
        }
    }
}
