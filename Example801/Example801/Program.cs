using System.IO;

namespace Example801
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
                StreamReader reader = new StreamReader(filename);
                string temp = "";
                int cunt = 1;

                while ((temp = reader.ReadLine()) != null)
                {
                    Console.WriteLine("{0,2}) {1}", cunt++, temp.Replace(",", "\t"));
                }

                reader.Close();
            }



            Console.ReadKey();
        }
    }
}
