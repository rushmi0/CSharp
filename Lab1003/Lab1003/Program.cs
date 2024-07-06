using System;

namespace Lab1003
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            line();
            Console.WriteLine("\t\t\tTNI Deliver");
            int sum = 0;
            line();
            ListMenu();
            line();
            while (true)
            {
                Console.Write("Input the number of menu : ");
                int menu = int.Parse(Console.ReadLine());
                if (menu == 1) { sum += 100; }
                else if (menu == 2) { sum += 100; }
                else if (menu == 3) { sum += 250; }
                else if (menu == 4) { break; }
                else { continue; }
            }
            Console.WriteLine("Total price = {0:n}", sum);
            Console.WriteLine("Currnet time is {0}", DateTime.Now.ToString("HH:mm"));
            Console.WriteLine("Oders will be delivered at {0}", DateTime.Now.AddMinutes(30).ToString("HH:mm"));
            Console.ReadKey();
        }

        static void ListMenu()
        {
            Console.WriteLine("Takayaki\t\t100 Bath.");
            Console.WriteLine("Udon\t\t\t100 Bath.");
            Console.WriteLine("Takayaki\t\t250 Bath.");
            Console.WriteLine("Calculate\t\t100 Bath.");
        }

        static void line()
        {
            Console.WriteLine("--------------------------------------------");
        }
    }
}
