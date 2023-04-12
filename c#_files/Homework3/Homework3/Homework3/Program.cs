using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\Homework3\\Homework3\\input.txt";
        string outputFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\Homework3\\Homework3\\output.txt";

        string[] lines = File.ReadAllLines(inputFilePath);

        int emptyLines = RemoveIdenticalLines(lines);

        Array.Resize(ref lines, lines.Length - emptyLines);

        File.WriteAllLines(outputFilePath, lines);
    }

    static int RemoveIdenticalLines(string[] lines)
    {
        int i = 0, emptyLines = 0;

        while (i < lines.Length - emptyLines)
        {
            int j = i + 1;
            while (j < lines.Length - emptyLines)
            {
                if (lines[i] == lines[j])
                {
                    int k = j;
                    while (k < lines.Length - emptyLines - 1)
                    {
                        lines[k] = lines[k + 1];
                        k++;
                    }
                    emptyLines++;
                }
                else
                {
                    j++;
                }
            }
            i++;
        }

        return emptyLines;
    }
}
