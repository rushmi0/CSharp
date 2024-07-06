using System;

namespace Lab1104
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input student ID : ");
            string id = Console.ReadLine();
            while (CheckId(id) == false)
            {
                Console.Write("Input student ID, again ");
                id = Console.ReadLine();
            }
            Console.WriteLine("Your student ID = {0}", id);
            Console.ReadKey();

        }

        static bool CheckId(string id)
        {
            if (id.Length > 10)
            {
                return false;
            }
            foreach (int let in id)
            {
                if (let > 0 && let < 256 && let < 48 && let > 57)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
