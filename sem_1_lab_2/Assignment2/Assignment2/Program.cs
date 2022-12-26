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
    }
}