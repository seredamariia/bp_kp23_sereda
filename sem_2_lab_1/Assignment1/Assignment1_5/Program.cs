using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string FilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_5\\Task5.txt";

        /*test cases:
            case 1:
                Task5.txt: This is an example text. Try out something different.
            case 2:
                Task5.txt: abba ABBa ABBA
                           fgba fgbA FGbA
                           Abba FGBA gbBA
            case 3:
                Task5.txt: This is the first sentence in the first line
                           And this is the second sentence in the second line
         */

        string[] lines = File.ReadAllLines(FilePath);
        string[,] WordsAndCounts = new string[1000, 2];

        int index = 0;

        /*test cases:
            case 1:
                this 1
                is 1
                an 1
                example 1
                text 2
                try 1
                out 1
                different 1
            case 2:
                abba 4
                fgba 5
            case 3:
                this 2
                is 2
                the 4
                first 2
                sentence 2
                in 2
                line 2
                and 1
                second 2
         */
    }

    static string[,] SplitAndCount(string lines, string[,] WordsAndCounts, int index)
    {
        return WordsAndCounts;
    }
}