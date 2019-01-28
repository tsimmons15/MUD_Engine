using Revisits.Characters.CommandParser;
using System;

namespace Revisits
{
    class Program
    {
        static Parser parser;
        static void Main(string[] args)
        {
            parser = new Parser();
            Console.WriteLine("Starting");

            while(true)
            {
                string line = Console.ReadLine();
                parser.Parse(line);


                if (parser.HasQuit())
                {

                }
            }

            Console.WriteLine("Good bye");
        }

        static void dBTesting(string[] args)
        {
            string fileName = "db.sdf";
            string password = "db";

            DatabaseInterface dbi = new DatabaseInterface(fileName, password);

            dbi.CreateDB();

            bool connectDb = dbi.ConnectDB();
            if (!connectDb)
                Console.WriteLine("Unable to connect DB");

            Console.ReadKey();
        }
    }
}
