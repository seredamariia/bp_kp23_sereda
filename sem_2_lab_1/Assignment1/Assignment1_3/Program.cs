using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string InputFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_3\\input.txt";
        string OutputFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_3\\output.txt";

        string[] words = File.ReadAllLines(InputFilePath);

        InsertionSort(words);

        File.WriteAllLines(OutputFilePath, words);
    }

    static void InsertionSort(string[] array)
    {
        
    }

    static int StringsCompare(string s1, string s2)
    {
        
    }
}
