using System;

namespace Lab303
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of customer : ");
            int NC = int.Parse(Console.ReadLine());
            float P = NC * 399;

            if (NC >= 7)
            {
                P = P - (P * 10 / 100);
            }
            Console.WriteLine("");
            Console.WriteLine("Amount to be paid {0:N} baht.", P);
            Console.ReadKey();
        }
    }
}
