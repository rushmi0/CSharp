using System.IO;

namespace Lab808
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filename = "file://Users/home/Documents/2013111089_++/StudentList107.csv";
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found...");
            }
            else
            {
                StreamReader reader = new StreamReader(filename);
                reader.ReadLine();
                string temp = "";
                int count = 1;
                Console.WriteLine("No.\tID\t\tFull Name");
                Consloe.WriteLine("----------------------------------------");
                while ((temp = reader.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    Console.WriteLine("{0,2}\t{1}\t{2}", count++, data[0], data[2]);
                }
                reader.Close();
            }
            Console.Readkey();
        }
    }
}
