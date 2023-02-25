using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string InputFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_3\\input.txt";
        string OutputFilePath = "C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_1\\Assignment1\\Assignment1_3\\output.txt";

        /*test cases:
            case 1:
                input.txt: programming
                           basics
                           office
            case 2:
                input.txt: catfish
                           cat
                           adorable
            case 3:
                input.txt: mainstream
                           organisation
                           queen
         */

        string[] words = File.ReadAllLines(InputFilePath);

        InsertionSort(words);

        File.WriteAllLines(OutputFilePath, words);

        /*test cases:
            case 1:
                input.txt: basics
                           office
                           programming
            case 2:
                input.txt: adorable
                           cat
                           catfish
            case 3:
                input.txt: mainstream
                           organisation
                           queen
         */
    }

    static void InsertionSort(string[] array)
    {
        
    }

    static int StringsCompare(string s1, string s2)
    {
        
    }
}
