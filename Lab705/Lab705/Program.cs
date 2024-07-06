using System;

namespace Lab705
{
    class Program
    {
        struct STUDENT
        {
            public string name;
            public int id, score;
        }
        static void Main(string[] args)
        {
            Console.Write("How many student in classroom : ");
            int classroom = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("INPUT STUDENT INFORMATION");
            Console.WriteLine("------------------------------------------");

            STUDENT[] student = new STUDENT[classroom];
            for (int i = 0; i < classroom; i++)
            {
                Console.WriteLine("INPUT INFORMATION OF STUDENT {0}:", i + 1);
                Console.Write("ID : ");
                student[i].id = int.Parse(Console.ReadLine());
                Console.Write("NAME : ");
                student[i].name = Console.ReadLine();
                Console.Write("SCORE : ");
                student[i].score = int.Parse(Console.ReadLine());
                while (student[i].score < 0 || student[i].score > 100)
                {
                    Console.Write("SCORE, again : ");
                    student[i].score = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("STUDENT ID | SCORE");
            Console.WriteLine("------------------");
            foreach (STUDENT _student in student)
            {
                Console.Write("{0} | ", _student.id);
                for (int j = 0; j < _student.score; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ({0})", _student.name);
            }
            Console.ReadKey();

        }
    }
}
