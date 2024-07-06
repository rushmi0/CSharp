using System;

namespace Lab1102
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input mid-term score : ");
            int mid = int.Parse(Console.ReadLine());
            Console.Write("Input final score : ");
            int final = int.Parse(Console.ReadLine());

            Console.WriteLine("your total score is {0}", FindTotalScore(mid, final));
            Console.WriteLine("your result is {0}", IsPass(FindTotalScore(mid, final)) ? "PASS" : "FAIL");
            Console.ReadKey();

        }

        static double FindTotalScore(double mid, double final)
        {
            mid = mid * 30 / 100;
            final = final * 70 / 100;
            return mid + final;
        }

        static bool IsPass(double total)
        {
            if (total >= 50)
                return true;
            return false;
        }
    }
}
