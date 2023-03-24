using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // Set the file path
        string filePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\Homework2\\Homework2_1\\ReadFrom.txt";

        // Read the entire file
        string fileContents = File.ReadAllText(filePath);

        // Write the file contents to the console
        Console.WriteLine(fileContents);

        // Write the file contents to a new file
        string newFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\Homework2\\Homework2_1\\WriteTo.txt";
        File.WriteAllText(newFilePath, fileContents);
    }
}
