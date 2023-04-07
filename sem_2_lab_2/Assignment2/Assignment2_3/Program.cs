using System;
using System.Runtime.Intrinsics;

class Vector
{
    private int[] vector;

    public Vector(int length)
    {
        
    }

    public void ReadElementsFromConsole()
    {
        
    }

    public int SumOfNegatives()
    {
        return sum;
    }

    public int SumOfNegatives(Vector otherVector)
    {
        return sum;
    }

    public int ProductOfEvenIndexes()
    {
        return product;
    }

    public int ProductOfEvenIndexes(Vector otherVector)
    {
        return prod;
    }

    public int NumberOfZeros()
    {
        return count;
    }

    public int NumberOfZeros(Vector otherVector)
    {
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the first vector: ");
        int length1 = int.Parse(Console.ReadLine());

        Vector vector1 = new Vector(length1);
        vector1.ReadElementsFromConsole();

        Console.Write("Enter the length of the second vector: ");
        int length2 = int.Parse(Console.ReadLine());

        Vector vector2 = new Vector(length2);
        vector2.ReadElementsFromConsole();

        /*test cases:
            case 1: length1 = 3
                    vector1 = { 1, -5, 3 }
                    length2 = 4
                    vector2 = { 10, 4, -1 }
            case 2: n = 1
                    length1 = 1
                    vector1 = { -12 }
                    length2 = 2
                    vector2 = { 5, 0 }
            case 3: n = 3
                    length1 = 3
                    vector1 = { 0, -8, 11 }
                    length2 = 4
                    vector2 = { 0, 0, 50, -2 }
         */

        Console.WriteLine($"Sum of negatives: {vector1.SumOfNegatives(vector2)}");
        Console.WriteLine($"Product of even indexes: {vector1.ProductOfEvenIndexes(vector2)}");
        Console.WriteLine($"Number of zeros: {vector1.NumberOfZeros(vector2)}");

        /*test cases:
            case 1: Sum of negatives: -6
                    Product of even indexes: -30
                    Number of zeros: 0
            case 2: Sum of negatives: -12
                    Product of even indexes: 7
                    Number of zeros: 1
            case 3: Sum of negatives: -10
                    Product of even indexes: 0
                    Number of zeros: 3
         */
    }
}
