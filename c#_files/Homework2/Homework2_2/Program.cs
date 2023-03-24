using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // Set the file path
        string filePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\Homework2\\Homework2_2\\ReadFrom.txt";

        // Open the file for reading
        FileStream fileStream = new FileStream(filePath, FileMode.Open);

        // Create a stream reader to read the file character by character
        StreamReader streamReader = new StreamReader(fileStream);

        // Open a new file for writing
        string newFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\Homework2\\Homework2_2\\WriteTo.txt";
        FileStream newFileStream = new FileStream(newFilePath, FileMode.Create);

        // Create a stream writer to write the file character by character
        StreamWriter streamWriter = new StreamWriter(newFileStream);

        // Read and write each character in the file
        while (!streamReader.EndOfStream)
        {
            char c = (char)streamReader.Read();
            streamWriter.Write(c);
        }

        // Close the streams
        streamReader.Close();
        streamWriter.Close();
    }
}
