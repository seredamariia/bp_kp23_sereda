using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string NumbersFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_2\\numbers.txt";
        string MaxFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_2\\max.txt";

        int max = 0;

        int[] numbers = new int[15];

        Random rand = new Random();

        using (StreamWriter sw = File.CreateText(NumbersFilePath))
        {
        }

        using (StreamWriter sw = File.CreateText(MaxFilePath))
        {
        }
    }
}
