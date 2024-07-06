using System;

namespace Example304
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input mobile bill : ");
            float bill = float.Parse(Console.ReadLine());
            Console.Write("Input member type : ");
            char type = char.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (type)
            {
                case 'g':
                case 'G':
                    Console.WriteLine("Gold Member get discount 5%");
                    bill = bill - (bill * 5 / 100);
                    break;

                case 'b':
                case 'B':
                    Console.WriteLine("Blue Member get discount 10%");
                    bill = bill - (bill * 10 / 100);
                    break;

                default:
                    Console.WriteLine("");
                    break;
            }
            Console.WriteLine("Amount to be paid {0:N} baht.", bill);
            Console.ReadKey();
        }
    }
}
