using System;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string FilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_4\\Task4.txt";

        /*test cases:
            case 1:
                Task4.txt: Lana,Beard,67
                           Fleur,Salazar,52
                           Gertrude,Caldwell,30
            case 2:
                Task4.txt: Keaton,Bernard,71
                           Sana,Mueller,64
                           Findlay,Cervantes,92
            case 3:
                Task4.txt: Woody,Bishop,33
                           Alys,Burns,44
                           Will,Gordon,55
         */

        string[] lines = File.ReadAllLines(FilePath);
        string[] data = new string[3];

        bool found = false;

        /*test cases:
            case 1:
                Fleur Salazar 52
                Gertrude Caldwell 30
            case 2:
                There are no student with the score that is less than 60 points
            case 3:
                Woody Bishop 33
                Alys Burns 44
                Will Gordon 55
         */
    }

    static string[] Split(string line, string[] data)
    {
        
    }
}
