using System.IO;

namespace Lab803
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filename = "D:\\2013111089\\Location.cvs";
            StreamWriter writer;
            if (File.Exists(filename) == false)
            {
                writer = new StreamWriter(filename, true);
                writer.WriteLine("Location ID ,Street Address,Postol Code,City");
                writer.Close;
            }
            writer = new StreamWriter(filename, true);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("INPUT INFORMATION OF BRANCH {0} : ",i + 1);
                Console.WritLine("------------------------------------------------");
                Console.Writ("Input Location ID : ");
                string location = Console.ReadLine();
                Console.Write("Input Street Address : ");
                string address = Console.Readline();
                Console.Write("Input Postol Code : ");
                int postol = int.Parse(Console.Readline());
                Console.Write("Input City name : ");
                string city = Console.ReadLine();
                Console.WriteLine();


                try
                {
                    writer.WriteLine("{0},{1},{2},{3}", location, address, postol, city);
                    Console.WriteLine("Add 1 Branch already...");
                }
                catch (IOException)
                {
                    Console.WriteLine("Cannot add branch...");
                }
            }
            writer.Close();
            Console.Readkey();
        }
        
    }
}
