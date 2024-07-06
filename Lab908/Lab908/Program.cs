using System.IO;

namespace Lab908
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filename = "D\\2013111089\\StudentList107.csv";
            string temp = "";
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not exists...");
            }
            else
            {
                StreamReader read = new StreamReader(filename);
                read.ReadLine();

                Console.WriteLine("STUDENT ID\tSTUDENT E-MAIL");
                Console.WriteLine("--------------------------------------");

                while ((temp = read.ReadLine()) != null)
                {
                    string[] data = temp.Split(',');
                    string[] fullname = data[2].Split(' ');

                    string name = fullname[0];
                    string _name = fullname[1];

                    Console.WriteLine("{0}\t{1}{2}.{3}_st@tni.ac.th",data[0],char.ToLower(_
                        [0]),char.ToLower(_
                        [1]),name.ToLower);
                }
                read.Close();
            }
            Console.WriteLine();
            Console.Readkey();
        }
    }
}
