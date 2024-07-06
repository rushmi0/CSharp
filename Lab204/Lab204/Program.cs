using System;

namespace Lab204
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string id = "2013110305", name = "Siripong Poolnuch", major = "IT", age = "18", bd = "2545";

            Console.WriteLine("STUDENT : {0,1} {1}", id, name);
            Console.WriteLine("MAJOR   : {0,1}", major);
            Console.WriteLine("AGE     : {0,1} (Born in {1})", age, bd);
            Console.ReadKey();
        }
    }
}
