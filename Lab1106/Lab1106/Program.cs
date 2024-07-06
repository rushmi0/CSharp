using System;

namespace Lab1106
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number of advisee is {0}", CountStudent());
            Console.WriteLine("-------------------------");
            ShowStudent();
            Console.ReadKey();

        }

        static int CountStudent()
        {
            string filename = "D:\\2013111089\\Advisee.csv";
            StreamReader reader = new StreamReader(filename);
            string temp = "";
            int count = 0;
            while ((temp = reader.ReadLine()) != null)
            {
                count++;
            }
            reader.Close();
            return count;
        }

        static void ShowStudent()
        {
            string filename = "D:\\2013111089\\Advisee.csv";
            StreamReader reader = new StreamReader(filename);
            string temp = "";
            while ((temp = reader.ReadLine()) != null)
            {
                string[] data = temp.Split(',');
                Console.WriteLine("{0}\t{1}", data[0], data[3]);
            }
            reader.Close();
        }
    }
}
