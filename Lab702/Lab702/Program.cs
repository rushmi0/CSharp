using System;

namespace Lab702
{
    class Program
    {
        struct Company
        {
            public string name;
            public int founded;

        }
        struct Employee
        {
            public string name;
            public char gender;
            public int hired_year;
        }
        static void Main(string[] args)
        {
            const int employee1 = 2020;

            Company company = new Company();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("INPUT COMPANY INFORMATION");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Input company name       : ");
            company.name = Console.ReadLine();

            Console.Write("Input company founded    : ");
            company.founded = int.Parse(Console.ReadLine());
            while (company.founded > employee1)
            {
                Console.Write("Input company founded, again : ");
                company.founded = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Employee employee = new Employee();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("INPUT EMPLOYEE INFORMATION");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Input Employee name      : ");
            employee.name = Console.ReadLine();

            Console.Write("Input Employee gender    : ");
            employee.gender = char.Parse(Console.ReadLine());
            while (Char.ToUpper(employee.gender) != 'M' && Char.ToUpper(employee.gender) != 'F')
            {
                Console.Write("Input Employee gender, again    : ");
                employee.gender = char.Parse(Console.ReadLine());
            }

            Console.Write("Input hired year         : ");
            employee.hired_year = int.Parse(Console.ReadLine());
            while (employee.hired_year <= company.founded)
            {
                Console.Write("Input hired year, again         : ");
                employee.hired_year = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Employee name \"Mr.{0}\" worked at {1} for {2} year ", employee.name, company.name, employee.hired_year - company.founded);

            Console.ReadKey();
        }
    }
}
