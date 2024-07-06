using System;

namespace Example605
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] num = { { 11,12,13,14 },
                           { 15,16,17,18 },
                           { 19,20,21,22 }
                         };
            Console.WriteLine("Data in Table 3 rows 4 columns");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(0); j++)
                {
                    Console.Write("{0}", num[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
