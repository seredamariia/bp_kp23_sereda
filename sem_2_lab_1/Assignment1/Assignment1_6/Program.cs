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

        /*test cases:
            case 1:
                students.txt: Jorja,Elliott,81
                              Daniel,Saunders,93
                              Margie,Page,69
            case 2:
                students.txt: Zahra,Massey,75
                              Eden,Nunez,96
                              Cai,Sims,83
            case 3:
                students.txt: Isla,Bush,95
                              Jacqueline,Rasmussen,78
                              Saskia,Pugh,98
         */

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

        /*test cases:
            case 1:
                There are no students with the score  greater than 95 points
            case 2:
                Number of students with high scores: 1
                Eden Nunez 96
            case 3:
                Number of students with high scores: 1
                Saskia Pugh 98
         */
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
