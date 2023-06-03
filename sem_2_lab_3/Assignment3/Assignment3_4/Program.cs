using System;

public interface IIterator<T>
{
    bool HasNext { get; }
    T MoveNext();
}

public class RandomizedQueue<Item> : IIterator<Item>
{
    private Node first; // first node of the randomized queue
    private int count; // number of items in the randomized queue
    private Random random; // random number generator
    private Node current; // current node for iterator

    private class Node
    {
        public Item item;
        public Node next;
    }

    public RandomizedQueue()
    {
        first = null;
        count = 0;
        random = new Random();
        current = first;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int Size()
    {
        return count;
    }

    public void Enqueue(Item item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("Cannot enqueue null item.");
        }

        Node newNode = new Node();
        newNode.item = item;
        newNode.next = first;
        first = newNode;
        count++;
    }

    public Item Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Randomized queue is empty.");
        }

        int randomIndex = random.Next(count);
        Node prevNode = null;
        Node currentNode = first;

        for (int i = 0; i < randomIndex; i++)
        {
            prevNode = currentNode;
            currentNode = currentNode.next;
        }

        if (prevNode != null)
        {
            prevNode.next = currentNode.next;
        }
        else
        {
            first = currentNode.next;
        }

        count--;
        return currentNode.item;
    }

    public Item Sample()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Randomized queue is empty.");
        }

        int randomIndex = random.Next(count);
        Node currentNode = first;

        for (int i = 0; i < randomIndex; i++)
        {
            currentNode = currentNode.next;
        }

        return currentNode.item;
    }

    public IIterator<Item> Iterator()
    {
        current = first; // Reset iterator to the beginning
        return this;
    }

    public bool HasNext { get { return current != null; } }

    public Item MoveNext()
    {
        if (!HasNext)
        {
            throw new InvalidOperationException("No more elements.");
        }

        Item item = current.item;
        current = current.next;
        return item;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        RandomizedQueue<string> queue = new RandomizedQueue<string>();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        queue.Enqueue("D");
        queue.Enqueue("E");

        Console.WriteLine("Queue size: " + queue.Size());

        Console.Write("Printing all items in the queue: ");
        IIterator<string> iterator = queue.Iterator();
        while (iterator.HasNext)
        {
            string item = iterator.MoveNext();
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Sample item: " + queue.Sample());
        Console.WriteLine("Dequeued item: " + queue.Dequeue());

        Console.Write("Printing all items in the queue: ");
        iterator = queue.Iterator();
        while (iterator.HasNext)
        {
            string item = iterator.MoveNext();
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

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