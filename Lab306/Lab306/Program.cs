using System;

namespace Lab306
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("input exercise score : ");
            int ES = int.Parse(Console.ReadLine());
            Console.Write("input mid-term score : ");
            int MS = int.Parse(Console.ReadLine());
            Console.Write("input final score : ");
            int FS = int.Parse(Console.ReadLine());


            int TS = ES + MS + FS;
            string G;

            if (TS < 0)
            {
                G = "Error";
            }
            else if (TS <= 49)
            {
                G = "F";
            }
            else if (TS <= 54)
            {
                G = "D";
            }
            else if (TS <= 59)
            {
                G = "D+";
            }
            else if (TS <= 64)
            {
                G = "C";
            }
            else if (TS <= 69)
            {
                G = "C+";
            }
            else if (TS <= 74)
            {
                G = "B";
            }
            else if (TS <= 79)
            {
                G = "B+";
            }
            else if (TS <= 100)
            {
                G = "A";
            }
            else
            {
                G = "Error";
            }
            Console.WriteLine("");
            Console.WriteLine("Your total score is {0}, get grade {1}", TS, G);
            Console.ReadKey();
        }
    }
}
