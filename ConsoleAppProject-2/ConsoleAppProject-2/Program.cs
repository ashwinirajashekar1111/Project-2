using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Mphasis -B233\Project-2\Student Info .text";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path.");
        }
    }
}
