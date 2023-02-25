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
        for (int i = 1; i < array.Length; i++)
        {
            string key = array[i];
            int j = i - 1;
            while (j >= 0 && StringsCompare(array[j], key) > 0)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    static int StringsCompare(string s1, string s2)
    {
        int MinLen = Math.Min(s1.Length, s2.Length);

        for (int i = 0; i < MinLen; i++)
        {
            if (s1[i] != s2[i])
            {
                return s1[i] - s2[i];
            }
        }

        if (s1.Length != s2.Length)
        {
            return s1.Length - s2.Length;
        }

        return 0;
    }
}
