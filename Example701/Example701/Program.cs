using System;

namespace Example701
{
    class Program
    {
        struct Subject
        {
            public string id, name;
            public int credit;
        }
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Console.Write("Input Subject id : ");
            subject.id = Console.ReadLine();
            Console.Write("Input Subject name : ");
            subject.name = Console.ReadLine();
            Console.Write("Input Subject credit : ");
            subject.credit = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Subject = {0} ({1})", subject.name, subject.id);
            Console.WriteLine("Total price = {0:n} bath.", subject.credit * 1500);

            Console.ReadKey();


        }
    }
}
