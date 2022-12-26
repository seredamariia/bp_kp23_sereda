using System;

namespace Percolation
{
    class Peroclation
    {
        static void Main()
        {
            int n, row, col, site;
            char a, b;

            while (true)
            {
                Console.WriteLine("Enter size of matrix greater than or equal 2");
                n = Convert.ToInt32(Console.ReadLine());

                int[,] original = new int[n, n];

                int[,] index = new int[n, n];
                init_index(index);

                int[] status = new int[n * n + 1];
                init_status(status);

                if (n < 2)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Do you want to generate matrix RANDOMLY or open sites YOURSELF?");
                    Console.WriteLine("Enter R for RANDOMLY or Y for YOURSELF");
                    a = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();

                    if (a == 'Y' || a == 'y')
                    {
                        print(original);
                        Console.WriteLine();

                        while (true)
                        {
                            Console.WriteLine("Enter the index of the row of the site you want to open");
                            row = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the index of the column of the site you want to open");
                            col = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            Open(row - 1, col - 1, original, index, status);
                            print(original);

                            Console.WriteLine("Do you want to CONTINUE and OPEN ANOTHER SITE or do you want to STOP and CHECK THE SYSTEM FOR PERCOLATION?");
                            Console.WriteLine("Enter C to CONTINUE or S to STOP");
                            b = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine();

                            if ((b == 'C') || (b == 'c'))
                            {
                                continue;
                            }
                            if ((b == 'S') || (b == 's'))
                            {
                                break;
                            }
                        }
                    }

                    if (a == 'R' || a == 'r')
                    {
                        init_r(original);
                        print(original);
                        Console.WriteLine();
                        for (int j = 0; j < n; j++)
                        {
                            if (isFull(0, j, original))
                            {
                                site = index[0, j];
                                union(0, site, index, status);
                            }
                        }
                        for (int j = 0; j < n; j++)
                        {
                            check_random(1, j, original, index, status);
                        }
                    }
                    print(original);
                    Console.WriteLine("Number of open sites: " + numberOfOpenSites(original));
                    Console.WriteLine("Does the system peroclates? " + percolates(original));
                }
                break;
            }

            Console.WriteLine();
            int[,] test_original = new int[5, 5];

            int[,] test_index = new int[5, 5];
            init_index(test_index);

            int[] test_status = new int[5 * 5 + 1];
            init_status(test_status);
        }

        static int[,] init_index(int[,] array)
        {
            return array;
        }
        static int[] init_status(int[] array)
        {
            return array;
        }

        static int[,] init_r(int[,] array)
        {
            return array;
        }
        static void union(int site_1, int site_2, int[,] index, int[] status)
        {
            
        }

        static Boolean connected(int site_1, int site_2, int[] status)
        {
            
        }

        static int root(int site_1, int[] status)
        {
            
        }

        static void Open(int row, int col, int[,] original, int[,] index, int[] status)
        {
            
        }

        static void check_random(int row, int col, int[,] original, int[,] index, int[] status)
        {
            
        }

        static Boolean isOpen(int row, int col, int[,] array)
        {
            
        }

        static Boolean isFull(int row, int col, int[,] array)
        {
            
        }

        static int numberOfOpenSites(int[,] array)
        {
            return numberOfOpenSites;
        }

        static Boolean percolates(int[,] array)
        {
            
        }

        static void print(int[,] array)
        {
            
        }

        static Boolean TestInit_index()
        {
            int[,] array1 = new int[2, 2]; //n = 2
            int[,] array2 = new int[3, 3]; //n = 3
            int[,] array3 = new int[4, 4]; //n = 4
            int[,] array4 = new int[5, 5]; //n = 5

            int[,] expected1 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] expected2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] expected3 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int[,] expected4 = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };

            int[,] actual1 = init_index(array1);
            int[,] actual2 = init_index(array2);
            int[,] actual3 = init_index(array3);
            int[,] actual4 = init_index(array4);

            if (string.Join(",", actual1) == string.Join(",", expected1) == false)
            {
                Console.WriteLine("TestInit_index: case1 FAILED");
                return false;
            }

            if (string.Join(",", actual2) == string.Join(",", expected2) == false)
            {
                Console.WriteLine("TestInit_index: case1 FAILED");
                return false;
            }

            if (string.Join(",", actual3) == string.Join(",", expected3) == false)
            {
                Console.WriteLine("TestInit_index: case1 FAILED");
                return false;
            }

            if (string.Join(",", actual4) == string.Join(",", expected4) == false)
            {
                Console.WriteLine("TestInit_index: case1 FAILED");
                return false;
            }

            Console.WriteLine("TestInit_index: all cases PASSED");
            return true;
        }

        static Boolean TestInit_status()
        {
            int[] array1 = new int[5]; //n = 2
            int[] array2 = new int[10]; //n = 3
            int[] array3 = new int[17]; //n = 4

            int[] expected1 = new int[] { 0, 1, 2, 3, 4 };
            int[] expected2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected3 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            int[] actual1 = init_status(array1);
            int[] actual2 = init_status(array2);
            int[] actual3 = init_status(array3);

            if (string.Join(",", actual1) == string.Join(",", expected1) == false)
            {
                Console.WriteLine("TestInit_status: case1 FAILED");
                return false;
            }

            if (string.Join(",", actual2) == string.Join(",", expected2) == false)
            {
                Console.WriteLine("TestInit_status: case1 FAILED");
                return false;
            }

            if (string.Join(",", actual3) == string.Join(",", expected3) == false)
            {
                Console.WriteLine("TestInit_status: case1 FAILED");
                return false;
            }

            Console.WriteLine("TestInit_status: all cases PASSED");
            return true;
        }

        static Boolean TestOpen(int[,] test_original, int[,] test_index, int[] test_status)
        {
            //for matrix of size at least 5
            int expected1 = 2; // row = 0 col = 0
            int expected2 = 2; // row = 1 col = 0
            int expected3 = 1; // row = 1 col = 3
            int expected4 = 1; // row = 2 col = 3
            int expected5 = 1; // row = 4 col = 4

            Open(0, 0, test_original, test_index, test_status);
            int actual1 = test_original[0, 0];

            Open(1, 0, test_original, test_index, test_status);
            int actual2 = test_original[1, 0];

            Open(1, 3, test_original, test_index, test_status);
            int actual3 = test_original[1, 3];

            Open(2, 3, test_original, test_index, test_status);
            int actual4 = test_original[2, 3];

            Open(4, 4, test_original, test_index, test_status);
            int actual5 = test_original[4, 4];

            if (actual1 != expected1)
            {
                Console.WriteLine("TestOpen: case1 FAILED");
                return false;
            }

            if (actual2 != expected2)
            {
                Console.WriteLine("TestOpen: case2 FAILED");
                return false;
            }

            if (actual3 != expected3)
            {
                Console.WriteLine("TestOpen: case3 FAILED");
                return false;
            }

            if (actual4 != expected4)
            {
                Console.WriteLine("TestOpen: case4 FAILED");
                return false;
            }

            if (actual5 != expected5)
            {
                Console.WriteLine("TestOpen: case5 FAILED");
                return false;
            }

            Console.WriteLine("TestOpen: all cases PASSED");
            return true;
        }

        static Boolean TestUnion(int[,] test_index, int[] test_status)
        {
            //for matrix of size at least 5

            union(16, 17, test_index, test_status);
            union(16, 21, test_index, test_status);
            union(17, 22, test_index, test_status);

            if (test_status[16] != test_status[17])
            {
                Console.WriteLine("TestUnion: case1 FAILED");
                return false;
            }

            if (test_status[21] != test_status[16])
            {
                Console.WriteLine("TestUnion: case2 FAILED");
                return false;
            }

            if (test_status[17] != test_status[22])
            {
                Console.WriteLine("TestUnion: case3 FAILED");
                return false;
            }

            Console.WriteLine("TestUnion: all cases PASSED");
            return true;
        }

        static Boolean TestConnected(int[] test_status)
        {
            //for matrix of size at least 5
            bool expected1 = true; //16 17
            bool expected2 = false; // 11 12
            bool expected3 = false; // 9 10

            bool actual1 = connected(16, 17, test_status);
            bool actual2 = connected(11, 12, test_status);
            bool actual3 = connected(9, 10, test_status);

            if (actual1 != expected1)
            {
                Console.WriteLine("TestConnected: case1 FAILED");
                return false;
            }

            if (actual2 != expected2)
            {
                Console.WriteLine("TestConnected: case2 FAILED");
                return false;
            }

            if (actual3 != expected3)
            {
                Console.WriteLine("TestConnected: case3 FAILED");
                return false;
            }

            Console.WriteLine("TestConnected: all cases PASSED");
            return true;
        }

        static Boolean TestRoot(int[] test_status)
        {
            //for matrix of size at least 5
            int expected1 = 16; // 22
            int expected2 = 15; // 15
            int expected3 = 16; // 21

            int actual1 = root(22, test_status);
            int actual2 = root(15, test_status);
            int actual3 = root(21, test_status);

            if (actual1 != expected1)
            {
                Console.WriteLine("TestRoot: case1 FAILED");
                return false;
            }

            if (actual2 != expected2)
            {
                Console.WriteLine("TestRoot: case2 FAILED");
                return false;
            }

            if (actual3 != expected3)
            {
                Console.WriteLine("TestRoot: case3 FAILED");
                return false;
            }

            Console.WriteLine("TestRoot: all cases PASSED");
            return true;
        }

        static Boolean TestisOpen(int[,] test_original)
        {
            bool expected1 = false; // row = 2 col = 0
            bool expected2 = false; // row = 0 col = 4
            bool expected3 = false; // row = 0 col = 0
            bool expected4 = true; // row = 1 col = 3

            bool actual1 = isOpen(2, 0, test_original);
            bool actual2 = isOpen(0, 4, test_original);
            bool actual3 = isOpen(0, 0, test_original);
            bool actual4 = isOpen(1, 3, test_original);

            if (actual1 != expected1)
            {
                Console.WriteLine("TestisOpen: case1 FAILED");
                return false;
            }

            if (actual2 != expected2)
            {
                Console.WriteLine("TestisOpen: case2 FAILED");
                return false;
            }

            if (actual3 != expected3)
            {
                Console.WriteLine("TestisOpen: case3 FAILED");
                return false;
            }

            if (actual4 != expected4)
            {
                Console.WriteLine("TestisOpen: case4 FAILED");
                return false;
            }

            Console.WriteLine("TestisOpen: all cases PASSED");
            return true;
        }

        static Boolean TestisFull(int[,] test_original)
        {
            bool expected1 = false; // row = 2 col = 0
            bool expected2 = true; // row = 1 col = 0
            bool expected3 = true; // row = 0 col = 0
            bool expected4 = false; // row = 1 col = 3

            bool actual1 = isFull(2, 0, test_original);
            bool actual2 = isFull(1, 0, test_original);
            bool actual3 = isFull(0, 0, test_original);
            bool actual4 = isFull(1, 3, test_original);

            if (actual1 != expected1)
            {
                Console.WriteLine("TestisFull: case1 FAILED");
                return false;
            }

            if (actual2 != expected2)
            {
                Console.WriteLine("TestisFull: case2 FAILED");
                return false;
            }

            if (actual3 != expected3)
            {
                Console.WriteLine("TestisFull: case3 FAILED");
                return false;
            }

            if (actual4 != expected4)
            {
                Console.WriteLine("TestisFull: case4 FAILED");
                return false;
            }

            Console.WriteLine("TestisFull: all cases PASSED");
            return true;
        }

        static Boolean TestNumberOfOpenSites(int[,] test_original, int[,] test_index, int[] test_status)
        {
            int expected1 = 5;

            int actual1 = numberOfOpenSites(test_original);

            if (actual1 != expected1)
            {
                Console.WriteLine("TestNumberOfOpenSites: case1 FAILED");
                return false;
            }

            Open(1, 1, test_original, test_index, test_status);

            int expected2 = 6;

            int actual2 = numberOfOpenSites(test_original);

            if (actual2 != expected2)
            {
                Console.WriteLine("TestNumberOfOpenSites: case2 FAILED");
                return false;
            }

            Open(1, 2, test_original, test_index, test_status);

            int expected3 = 7;

            int actual3 = numberOfOpenSites(test_original);

            if (actual3 != expected3)
            {
                Console.WriteLine("TestNumberOfOpenSites: case3 FAILED");
                return false;
            }

            Console.WriteLine("TestNumberOfOpenSites: all cases PASSED");
            return true;
        }

        static Boolean TestPercolates(int[,] test_original, int[,] test_index, int[] test_status)
        {
            bool expected1 = false;

            bool actual1 = percolates(test_original);

            if (actual1 != expected1)
            {
                Console.WriteLine("TestPercolates: case1 FAILED");
                return false;
            }

            Open(3, 3, test_original, test_index, test_status);

            bool expected2 = false;

            bool actual2 = percolates(test_original);

            if (actual2 != expected2)
            {
                Console.WriteLine("TestPercolates: case2 FAILED");
                return false;
            }

            Open(4, 3, test_original, test_index, test_status);

            bool expected3 = true; //for matrix of size 5

            bool actual3 = percolates(test_original);

            if (actual3 != expected3)
            {
                Console.WriteLine("TestPercolates: case3 FAILED");
                return false;
            }

            Console.WriteLine("TestPercolates: all cases PASSED");
            return true;
        }
    }
}