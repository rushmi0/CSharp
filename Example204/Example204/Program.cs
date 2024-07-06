using System;

namespace Example204
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string name
            Console.Write("Input Studen Name : ");
            string name = Console.ReadLine();

            Console.Write("Input Birth Year : ");
            int birthyear = int.Parse(Console.ReadLine());

            Console.Write("Input Studen Grade : ");
            char grade = char.Parse(Console.ReadLine());


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Name  : {0}", name);
            Console.WriteLine("Age   : {0} (Born in {1})", DateTime.Now.Year - birthyear, birthyear);
            Console.WriteLine("Grade : {0}", grade);


            Console.ReadKey();
        }
    }
}
