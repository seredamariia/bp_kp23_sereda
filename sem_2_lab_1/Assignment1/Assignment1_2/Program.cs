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

        /*test cases:
            case 1:
                numbers.txt: 49 11 48 35 43 24 80 0 55 23 13 59 11 44 19
            case 2:
                numbers.txt: 57 36 76 85 10 59 42 19 98 22 43 98 14 56 87
            case 3:
                numbers.txt: 34 72 85 10 51 92 36 28 40 37 80 0 16 15 18
         */

        using (StreamWriter sw = File.CreateText(MaxFilePath))
        {
        }

        /*test cases:
            case 1:
                numbers.txt: 49 11 48 35 43 24 80 0 55 23 13 59 11 44 19
                max.txt: 80
            case 2:
                numbers.txt: 57 36 76 85 10 59 42 19 98 22 43 98 14 56 87
                max.txt: 98
            case 3:
                numbers.txt: 34 72 85 10 51 92 36 28 40 37 80 0 16 15 18
                max.txt: 92
         */
    }
}
