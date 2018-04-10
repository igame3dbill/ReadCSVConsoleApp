using System;
using System.IO;

namespace ReadCSVConsoleApp
{
    class Program
    {
        static void Main()
        {
            string[] records = File.ReadAllLines("Data.csv");
            while (true)
            {
                Console.Write("Enter first field or 'q' to quit : ");
                string first = Console.ReadLine();
                if (first == "q" || first == "Q") return;
                bool found = false;
                foreach (string record in records)
                {
                    if (record.StartsWith(first + ","))
                    {
                        string[] fields = record.Split(',');
                        int i = 0;
                        foreach (string content in fields)
                        {
                            Console.WriteLine("Field " + i + " is : {0}", fields[i]);
                            i++;
                        }
                        found = true;
                        break;
                    }
                }
                if (!found) Console.WriteLine("There is no record with a first field of {0}", first);
                Console.WriteLine();
            }
        }
    }
}
