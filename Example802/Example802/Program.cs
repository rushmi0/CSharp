using System.IO;

namespace Example802
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filename = "D:\\2013111089\\advisee.csv";

            if (File.Exists(filename) == false)
            {
                Console.WriteLine("File not found...");
            }
            else
            {
                Console.Write("Input student year : ");
                int year = int.Parse(Console.ReadLine());
                StreamReader reader = new StreamReader(filename);
                string temp = "";
                int count = 1;
                bool check = false;
                while ((temp = reader.ReadLine()) != null)
                {
                    //Console.WriteLine("{0,2}) {1}", cunt++, temp.Replace(",", "\t"));
                    // data[0] => id
                    // data[1] => student year
                    // data[2] => front name
                    // data[3] => fullname

                    string[] data = temp.Split(',');
                    if (int.Parse(data[1]) == year)
                    {
                        check = true;
                        Console.WriteLine("{0,2}) {1}", count++, data);
                    }
                }

                reader.Close();
                if (check == false)
                {
                    Console.WriteLine("No data found...");
                }
            }
            Console.ReadKey();
        }
    }
}
