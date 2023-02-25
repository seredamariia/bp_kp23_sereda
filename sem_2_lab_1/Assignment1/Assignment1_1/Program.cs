using System;
using System.ComponentModel;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string FilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_1\\Task1.txt";
        string[] lines = { };
        string[] FileContent = File.ReadAllLines(FilePath);
    }
}