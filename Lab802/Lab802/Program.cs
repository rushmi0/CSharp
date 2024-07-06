using System.IO;

namespace Lab802
{
    class MainClass
    {
        struct AS
        {
            public string Location_id; // รหัสสาขา
            public string street_address; // ชื่อถนน
            public string postal_code; // รหัสไปรษณีย์
            public string city; // ชื่อเมือง
        }
        public static void Main(string[] args)
        {

            string filename = "D:\\2013111089\\Location.csv";
            StreamWriter writer;
            if (File.Exists(filename) == false)
            {
                writer = new StreamWriter(filename, true);
                writer.WriteLine("Location ID ,Street address,Postal code,City");
                writer.Close();
            }
            writer = new StreamWriter(filename, true);

            AS _as = new AS();


            Console.Write("Input Location Id ");
            _as.Location_id = Console.ReadLine();
            Console.Write("Input Street address ");
            _as.street_address = Console.ReadLine();
            Console.Write("Input Postal code ");
            _as.postal_code = Console.ReadLine();
            Console.Write("Input City ");
            _as.city = Console.ReadLine();

            try
            {
                writer.WriteLine("{0},{1},{2},{3}", _as.Location_id, _as.street_address, _as.postal_code, _as.city);
                Console.WriteLine("Add 1 Branch already...");
            }
            catch (IOException)
            {
                Console.WriteLine("Cannot add branch...");
            }

            writer.Close();

            Console.ReadKey();
        }
    }
}
