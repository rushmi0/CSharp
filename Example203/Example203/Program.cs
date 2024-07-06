using System;

namespace Example203
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string id = "NB-001", name = "Notebook Series";
            int price = 25000;
            float VAT = price * 7 / 100;
            float total = price + VAT;

            Console.WriteLine("PRODUCT : {0} ({1})", id, name);
            Console.WriteLine("PRICE   : {0,10:N0} Baht.", price);
            Console.WriteLine("ADD VAT : {0,10:N0} Baht.", VAT);
            Console.WriteLine("TOTAL   : {0,10:N0} Baht.", total);

            Console.ReadKey();
        }
    }
}
