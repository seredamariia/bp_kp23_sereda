using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string CSVFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_6\\students.txt";
        string BinaryFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_6\\binary.bin";
        string HighScoresFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_6\\high_scores.bin";

        string[] lines = File.ReadAllLines(CSVFilePath);
        string[] data = new string[3];
        string[,] HighScoresRecords = new string[lines.Length, 3];
        int HighScoresCount = 0;

        using (BinaryWriter writer = new BinaryWriter(File.Open(BinaryFilePath, FileMode.Create)))
        {
            
        }

        using (BinaryWriter writer = new BinaryWriter(File.Open(HighScoresFilePath, FileMode.Create)))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(BinaryFilePath, FileMode.Open)))
            {
                
            }
        }

        using (BinaryReader reader = new BinaryReader(File.Open(HighScoresFilePath, FileMode.Open)))
        {
            
        }
    }

    static string[] Split(string line, string[] data)
    {
        string substring = "";
        int counter = 0;

        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] != ',')
            {
                substring = substring + line[i];
            }
            else
            {
                data[counter] = substring;
                counter++;
                substring = "";
            }
        }

        data[counter] = substring;

        return data;
    }
}
