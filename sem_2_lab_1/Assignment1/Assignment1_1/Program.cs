using System;
using System.ComponentModel;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string FilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_1\\Task1.txt";
        string[] lines = { "Write a program to create a text file that contains 2 lines.", "The content of the file should be displayed on the screen." };

        /*test cases:
            case 1: Write a program to create a text file that contains 2 lines.
                    The content of the file should be displayed on the screen.
            case 2: Content of the file.
            case 3: Task 1
                    Task 2
                    Task 3
                    Task 4
                    Task 5
                    Task 6
        */

        File.WriteAllLines(FilePath, lines);

        string[] FileContent = File.ReadAllLines(FilePath);
        foreach (string line in FileContent)
        {
            Console.WriteLine(line);
        }

        /*test cases:
            case 1: Write a program to create a text file that contains 2 lines.
                    The content of the file should be displayed on the screen.
            case 2: Content of the file.
            case 3: Task 1
                    Task 2
                    Task 3
                    Task 4
                    Task 5
                    Task 6
        */
    }
}