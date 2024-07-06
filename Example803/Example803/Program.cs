using System.IO;

namespace Example803
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //StreamWriter writer = new StreamWriter("D:\\2013111089\\hello.csv");
            string fiiename = "D:\\2013111089\\ProductStock.csv";
            StreamWriter writer = new StreamWriter(fiiename);
            while (true)
            {
                Console.Write("Input product id : ");
                string id = Console.ReadLine();
                if (id.Equals("-"))
                {
                    break;
                }
                Console.Write("Input product price : ");
                float price = float.Parse(Console.ReadLine());
                Console.Write("Input product unit : ");
                int unit = int.Parse(Console.ReadLine());
                try
                {
                    writer.WriteLine("{0},{2},{2}", id, price, unit);
                    Console.WriteLine("{0} save data already...", id);
                }
                catch (IOException)
                {
                    Console.WriteLine("{0} cannot save data...", id);
                }
                Console.WriteLine();
            }
            writer.Close();
            Console.ReadKey();

        }
    }
}
