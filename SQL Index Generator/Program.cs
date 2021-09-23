using System.IO;

namespace SQL_Index_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string database = "DatabaseToUse";

            using StreamReader reader = new StreamReader(@"C:\FileToRead.txt");
            using StreamWriter writer = new StreamWriter($@"C:\{database}-IndexesSQL.sql");

            //USE statement on top of script
            writer.WriteLine($"USE {database}\r\n");


            string test = "";

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] dataArray = line.Split(" ");

                string column = dataArray[0];
                string table = dataArray[2];

                //write SQL comment
                writer.WriteLine($"--{line}");
                writer.WriteLine($"CREATE INDEX {table}_{column}_idx\r\n" +
                                 $"ON {table} ({column});\r\n");
            }
        }
    }
}
