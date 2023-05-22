using System;

public interface IIterator<T>
{
    bool HasNext { get; }
    T MoveNext();
}

public class RandomizedQueue<Item> : IIterator<Item>
{
    private Item[] items; // array to store items
    private int count; // number of items in the randomized queue
    private Random random; // random number generator
    private int current; // current index for iterator

    public RandomizedQueue()
    {
        items = new Item[4];
        count = 0;
        random = new Random();
        current = 0;
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

        if (count == items.Length)
        {
            Resize(2 * items.Length); // double the array size if full
        }

        items[count++] = item;
    }

    public Item Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Randomized queue is empty.");
        }

        int randomIndex = random.Next(count);
        Item item = items[randomIndex];

        // Shift all elements after the dequeued item to the left
        for (int i = randomIndex; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        items[count - 1] = default(Item); // clear the last item
        count--;

        if (count > 0 && count == items.Length / 4)
        {
            Resize(items.Length / 2); // shrink the array if it's one-quarter full
        }

        return item;
    }

    public Item Sample()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Randomized queue is empty.");
        }

        int randomIndex = random.Next(count);
        return items[randomIndex];
    }

    public IIterator<Item> Iterator()
    {
        current = 0; // Reset iterator to the beginning
        return this;
    }

    public bool HasNext { get { return current < count; } }

    public Item MoveNext()
    {
        if (!HasNext)
        {
            throw new InvalidOperationException("No more elements.");
        }

        Item item = items[current++];
        return item;
    }

    private void Resize(int capacity)
    {
        Item[] resizedItems = new Item[capacity];
        for (int i = 0; i < count; i++)
        {
            resizedItems[i] = items[i];
        }
        items = resizedItems;
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
        RandomizedQueue<string> testQueue = new RandomizedQueue<string>();

        int expected1 = 0;
        int actual1 = testQueue.Size();

        bool expected2 = true;
        bool actual2 = testQueue.IsEmpty();

        if (actual1 != expected1)
        {
            Console.WriteLine("TestConstructor: Size check FAILED");
            return false;
        }

        if (actual2 != expected2)
        {
            Console.WriteLine("TestConstructor: IsEmpty check FAILED");
            return false;
        }

        Console.WriteLine("TestConstructor: All checks PASSED");
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