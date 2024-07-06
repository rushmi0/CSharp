using System.IO;

namespace Lab906
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filename = "D:\\2013111089\\Store.csv";
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exists...");
            }
            else
            {
                Console.Write("Input city name : ");
                string name = Console.ReadLine();
                name = name.ToUpper();
                Console.WriteLine();
                StreamReader reader = new StreamReader(filename);
                string temp = "";
                bool check = false;
                while ((temp = reader.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    if (name == data[2].ToUpper())
                    {
                        Console.WriteLine("Store ID {0} Extension No. is {1}", data[0], data[1]);
                        check = true;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("No data found...");
                }
                reader.Close();
            }

            Console.ReadKey();
        }
    }
}
