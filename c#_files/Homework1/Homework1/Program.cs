using System;
using System.IO;

namespace Percolation
{
    class Peroclation
    {
        static void Main()
        {
            string str1 = "", str0 = "";
            string str = File.ReadAllText("C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\unsorted_sequence_of_integers.txt");
            int[] array = new int[14];
            int n = 0, cell = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    str1 = str1 + str[i];
                }
                else
                {
                    array[n] = Convert.ToInt32(str1);
                    n++;
                    str1 = "";
                }
            }

            for (int i = 0; i < 14; i++)
            {
                bool sorted = true;

                for (int j = 1; j < 14; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        cell = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = cell;
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }

            for (int i = 0; i < 14; i++)
            {
                str0 = str0 + array[i] + " ";
            }

            File.WriteAllText("C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\c#_files\\sorted_sequence_of_integers.txt", str0);
        }
    }
}