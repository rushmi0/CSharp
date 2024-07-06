using System;

namespace Example702
{
    class Program
    {
        struct Subject
        {
            public string id;
            public int credit;
        }
        static void Main(string[] args)
        {
            Console.Write("How many subject to enrollment : ");
            int enroll = int.Parse(Console.ReadLine());

            Subject[] subject = new Subject[enroll];

            for (int i = 0; i < subject.Length; i++)
            {
                Console.Write("Input Subject id     : ");
                subject[i].id = Console.ReadLine();
                Console.Write("Input Subject credit : ");
;                subject[i ].credit = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int total = 0;
            foreach (Subject _subject in subject)
            {
                Console.WriteLine("{0} ({1} credit x 1500) = {2}", _subject.id, _subject.credit, _subject.credit * 1500);
                total += _subject.credit * 1500;
            }
            Console.WriteLine();
            Console.WriteLine("Total price of {0} subject = {1:n}", subject.Length,total);
            Console.ReadKey();
        }
    }
}
