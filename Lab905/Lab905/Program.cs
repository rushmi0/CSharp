using System.IO;

namespace Lab905
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ID\tCity\tName");
            Console.WriteLine("------------------------------");
            string filename = "D:\\2013111089\\Store.csv";
            if (!File.Exists(filename))
            {
                Console.WriteLine(" File not exists...");
            }
            else
            {
                StreamReader reader = new StreamReader(filename);
                reader.ReadLine();
                string temp = "";
                while ((temp = reader.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    Console.WriteLine("{0}\t{1} ({2})", data[0], data[2], data[1]);
                }
                reader.Close();
            }
            Console.ReadKey();
        }
    }
}
