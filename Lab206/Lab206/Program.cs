using System;

namespace Lab206
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double item = 3, price = 17500.25, total = item * price, Vtotal = total * 7 / 100 + total;
            Console.WriteLine("PRODUCT ID   = BN-158");
            Console.WriteLine("PRODUCT NAME = Notebook N-Series 7");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ITEM                    {0} items.", item);
            Console.WriteLine("PRICE            {0:n} baht.", price);
            Console.WriteLine("TOTAL            {0:n} baht.", total);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("VAT 7%           {0:n} baht.", Vtotal);
            Console.ReadKey();
        }
    }
}
