using System;

namespace Lab704
{
    struct Employee
    {
        public string name;
        public char gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("INPUT EMPLOYEE INFORMATION");
            Console.WriteLine("---------------------------------------------");
            Employee[] emp = new Employee[5];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Input information of employee {0}:", i + 1);
                Console.Write("NAME   : ");
                emp[i].name = Console.ReadLine();
                Console.Write("GENDER : ");
                emp[i].gender = char.Parse(Console.ReadLine());
                while (emp[i].gender != 'M' && emp[i].gender != 'm' && emp[i].gender != 'F' && emp[i].gender != 'f')
                {
                    Console.Write("GENDER, again : ");
                    emp[i].gender = char.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("DISPLAY EMPLOYEE INFORMATION (MALE)");
            Console.WriteLine("---------------------------------------------");
            int num = 1;
            foreach (Employee _emp in emp)
            {
                if (_emp.gender == 'M' || _emp.gender == 'm')
                {
                    Console.WriteLine("{0}. {1}", num, _emp.name);
                    num++;
                }
            }
            num = 1;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("DISPLAY EMPLOYEE INFORMATION (FEMALE)");
            Console.WriteLine("---------------------------------------------");
            foreach (Employee _emp in emp)
            {
                if (_emp.gender == 'F' || _emp.gender == 'f')
                {
                    Console.WriteLine("{0}. {1}", num, _emp.name);
                    num++;
                }
            }
            Console.ReadKey();
        }
    }
}
