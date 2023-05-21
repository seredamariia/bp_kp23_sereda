using System;

public interface IIterator<T>
{
    bool HasNext { get; }
    T MoveNext();
}

public class RandomizedQueue<Item> : IIterator<Item>
{
    private class Node
    {
        
    }

    public RandomizedQueue()
    {
        
    }

    public bool IsEmpty()
    {
        
    }

    public int Size()
    {
        
    }

    public void Enqueue(Item item)
    {
        
    }

    public Item Dequeue()
    {
        
    }

    public Item Sample()
    {
        
    }

    public IIterator<Item> Iterator()
    {
        
    }

    public bool HasNext { get {  } }

    public Item MoveNext()
    {
        
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        RandomizedQueue<int> test_queue = new RandomizedQueue<int>();
        RandomizedQueueTests.TestConstructor();
        RandomizedQueueTests.TestEnqueue(test_queue);
        RandomizedQueueTests.TestIterator(test_queue);
    }
}

public class RandomizedQueueTests
{
    public static bool TestConstructor()
    {
        RandomizedQueue<int> test_queue = new RandomizedQueue<int>();

        int expected1 = 0;
        int actual1 = test_queue.Size();

        bool expected2 = true;
        bool actual2 = test_queue.IsEmpty();

        if (actual1 != expected1)
        {
            Console.WriteLine("TestConstructor: case1 FAILED");
            return false;
        }
        if (actual2 != expected2)
        {
            Console.WriteLine("TestConstructor: case2 FAILED");
            return false;
        }

        Console.WriteLine("TestConstructor: all cases PASSED");
        return true;
    }

    public static bool TestEnqueue(RandomizedQueue<int> test_queue)
    {
        test_queue.Enqueue(1);
        int expected1 = 1;
        int actual1 = test_queue.Size();

        test_queue.Enqueue(2);
        int expected2 = 2;
        int actual2 = test_queue.Size();

        test_queue.Enqueue(3);
        int expected3 = 3;
        int actual3 = test_queue.Size();

        if (actual1 != expected1)
        {
            Console.WriteLine("TestEnqueue: case1 FAILED");
            return false;
        }
        if (actual2 != expected2)
        {
            Console.WriteLine("TestEnqueue: case2 FAILED");
            return false;
        }
        if (actual3 != expected3)
        {
            Console.WriteLine("TestEnqueue: case3 FAILED");
            return false;
        }

        Console.WriteLine("TestEnqueue: all cases PASSED");
        return true;
    }

    public static void TestIterator(RandomizedQueue<int> test_queue)
    {
        Console.WriteLine("Testing Iterator()...");

        test_queue.Enqueue(10);
        test_queue.Enqueue(20);
        test_queue.Enqueue(30);

        Console.Write("Items in the queue: ");

        IIterator<int> iterator = test_queue.Iterator();
        while (iterator.HasNext)
        {
            Console.Write(iterator.MoveNext() + " ");
        }

        Console.WriteLine();
    }
}