using System.IO;

namespace Lab907
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filename = "D:\\2013111089\\StudentList107.csv";
            if (!File.Exists(filename))
            {
                Console.WriteLine(" File not exists...");
            }
            else
            {
                StreamReader sr = new StreamReader(filename);
                sr.ReadLine();
                string temp = "";
                int count = 1;
                Console.WriteLine("List of female students");
                Console.WriteLine("--------------------------------------");
                while ((temp = sr.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (data[1] == "Miss")
                    {
                        Console.WriteLine("{0,2}) {1} {2}", count++, data[0], data[2]);
                    }
                }
                sr.Close();

                Console.WriteLine();
                Console.WriteLine();

                StreamReader se = new StreamReader(filename);

                string temp1 = "";
                int count1 = 1;
                Console.WriteLine("List of male students");
                Console.WriteLine("--------------------------------------");
                while ((temp = se.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (data[1] == "Mr.")
                    {
                        Console.WriteLine("{0,2}) {1} {2}", count1++, data[0], data[2]);
                    }
                }
                sr.Close();
            }
            Console.ReadKey();
        }
    }
}
