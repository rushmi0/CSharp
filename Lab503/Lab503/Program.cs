using System;

namespace Lab503
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float price = 0, sum = 0;
            int num = 0;

            for (int i = 1; i > 0; i++)
            {
                Console.Write("Input product {0} : ", i);
                price = float.Parse(Console.ReadLine());

                if (price <= 0)  //(price < 1) 
                {
                    break;
                }
                num = num + 1;
                sum = sum + price;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You buy {0} products", num);
            Console.WriteLine("Total price\t{0:N}", sum);
            Console.WriteLine("Total price\t{0:N}", sum + (sum * 7 / 100));
            Console.ReadKey();
        }
    }
}
