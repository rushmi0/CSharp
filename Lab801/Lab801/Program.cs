using System.IO;

namespace Lab801
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float total = 0;
            string fiiename = "D:\\2013111089\\ProductStock.csv";

            if (!File.Exists(fiiename) == false)
            {
                Console.Write("File not found...");
            }
            else
            {
                StreamReader reader = new StreamReader(fiiename);
                reader.ReadLine();
                string temp = " ";

                //bool check = false;
                while ((temp = reader.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    //data[0] => product id
                    float price = float.Parse(Console.ReadLine());
                    int unit = int.Parse(Console.ReadLine());

                    Console.WriteLine("Total price of {0} is {1:n} bath.", data[0], price * unit);

                    float sum = price * unit;
                    total = total + sum;
                }
                Console.WriteLine();
                Console.WriteLine("All total price is {0:n} bath.", total);
                reader.Close();
                Console.ReadKey();
            }
    }
}
