using System.IO;

namespace Lab904
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filename = "D:\\2013111089\\Store.csv";
            
            StreamWriter writer = new StreamWriter(filename, true);
            int count = 1;
            while (true)
            {
                Console.Write("Input Store ID : ");
                string id = Console.ReadLine();
                if (id.Equals("-"))
                {
                    break;
                }
                Console.Write("Input Extension No. : ");
                int xs = int.Parse(Console.ReadLine());
                Console.Write("Input City name : ");
                string ct = Console.ReadLine();

                try
                {
                    writer.WriteLine("{0},{1},{2}", id, xs, ct);
                }
                catch (IOException)
                {
                    Console.WriteLine("{0} save data success !! ");
                }
                Console.WriteLine();
            }
            writer.Close();
            Console.ReadKey();
        }
    }
}
