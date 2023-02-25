using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string FilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_5\\Task5.txt";

        string[] lines = File.ReadAllLines(FilePath);
        string[,] WordsAndCounts = new string[1000, 2];

        int index = 0;
    }

    static string[,] SplitAndCount(string lines, string[,] WordsAndCounts, int index)
    {
        return WordsAndCounts;
    }
}