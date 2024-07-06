using System;

namespace Lab209
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input student id     : ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Input student name   :");
            string N = Console.ReadLine();
            Console.Write("Input mid-term score :");
            int MidS = int.Parse(Console.ReadLine());
            Console.Write("Input final score    :");
            int FS = int.Parse(Console.ReadLine());
            int TS = MidS + FS;
            Console.WriteLine("-------------------------");
            Console.WriteLine("STUDENT   :{0} ({1})", N, ID);
            Console.WriteLine("GET SCORE :{0} ({1} + {2})", TS, MidS, FS);
            Console.ReadKey();
        }
    }
}
