using System;

namespace Lab210
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\tCalculate Your BMI");
            Console.WriteLine("----------------------------------");

            Console.Write("Input your height (cm.) : ");
            float hei = float.Parse(Console.ReadLine());

            Console.Write("Input your weight (kg.) : ");
            float wei = float.Parse(Console.ReadLine());

            float heiuse = hei / 100;
            float total = wei / (heiuse * heiuse);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Find BMI = {0} / ({1} x {2})", wei, heiuse, heiuse);
            Console.WriteLine("= {0:N}", total);

            Console.ReadKey();
        }
    }
}
