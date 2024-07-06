using System;

namespace Example1001
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input date : ");
            int date = int.Parse(Console.ReadLine());
            Console.Write("Input month : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Input year : ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine();

            try
            {
                DateTime datetime = new DateTime(year, month, date);
                Console.WriteLine("Input Date is {0}", datetime.ToString("dd MMMM yyyy"));
                Console.WriteLine("Next Date is {0}", datetime.AddDays(1).ToString("dd MMMM yyyy"));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The date you input id wrong...");
            }

            Console.ReadKey();

        }
    }
}
