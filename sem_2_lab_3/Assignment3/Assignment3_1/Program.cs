using System;

public class Deque<Item> : IIterator<Item>
{
    private const int DefaultCapacity = 4;

    private Item[] items;
    private int first;
    private int last;
    private int count;

    private int capacity;

    private int currentIndex;

    public Deque()
    {
        capacity = DefaultCapacity;
        items = new Item[capacity];
        first = 0;
        last = capacity - 1;
        count = 0;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int Size()
    {
        return count;
    }

    public void AddFirst(Item item)
    {
        if (item == null)
            throw new ArgumentNullException();

        if (count == capacity)
            Resize(capacity * 2);

        first = (first - 1 + capacity) % capacity;
        items[first] = item;
        count++;
    }

    public void AddLast(Item item)
    {
        if (item == null)
            throw new ArgumentNullException();

        if (count == capacity)
            Resize(capacity * 2);

        last = (last + 1) % capacity;
        items[last] = item;
        count++;
    }

    public Item RemoveFirst()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Deque is empty.");

        Item item = items[first];
        items[first] = default(Item); // Clear the reference to help with garbage collection
        first = (first + 1) % capacity;
        count--;

        if (count > 0 && count == capacity / 4)
            Resize(capacity / 2);

        return item;
    }

    public Item RemoveLast()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Deque is empty.");

        Item item = items[last];
        items[last] = default(Item); // Clear the reference to help with garbage collection
        last = (last - 1 + capacity) % capacity;
        count--;

        if (count > 0 && count == capacity / 4)
            Resize(capacity / 2);

        return item;
    }

    public IIterator<Item> Iterator()
    {
        currentIndex = first;
        return this;
    }

    public bool HasNext => currentIndex != (last + 1) % capacity;

    public Item MoveNext()
    {
        if (!HasNext)
            throw new InvalidOperationException("No more elements.");

        Item item = items[currentIndex];
        currentIndex = (currentIndex + 1) % capacity;
        return item;
    }

    private void Resize(int newCapacity)
    {
        Item[] newItems = new Item[newCapacity];

        int current = first;
        for (int i = 0; i < count; i++)
        {
            newItems[i] = items[current];
            current = (current + 1) % capacity;
        }

        items = newItems;
        capacity = newCapacity;
        first = 0;
        last = count - 1;
    }
}

public interface IIterator<T>
{
    bool HasNext { get; }
    T MoveNext();
}

public class Program
{
    public static void Main(string[] args)
    {
        Deque<int> deque = new Deque<int>();

        deque.AddFirst(10);
        deque.AddFirst(27);
        deque.AddFirst(50);
        deque.AddLast(33);
        deque.AddLast(49);
        deque.AddLast(78);
        deque.AddLast(90);

        Console.WriteLine("Size: " + deque.Size());
        Console.WriteLine("Is Empty: " + deque.IsEmpty());

        Console.Write("Items in order from front to back: ");
        IIterator<int> iterator = deque.Iterator();
        while (iterator.HasNext)
        {
            Console.Write(iterator.MoveNext() + " ");
        }
        Console.WriteLine();

        int removedItem = deque.RemoveFirst();
        Console.WriteLine("Removed item from the front: " + removedItem);

        removedItem = deque.RemoveLast();
        Console.WriteLine("Removed item from the back: " + removedItem);

        Console.Write("Items in order from front to back: ");
        iterator = deque.Iterator();
        while (iterator.HasNext)
        {
            Console.Write(iterator.MoveNext() + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        Deque<int> test_deque = new Deque<int>();
        DequeTests.TestConstructor();
        DequeTests.TestAddFirst(test_deque);
        DequeTests.TestAddLast(test_deque);
        DequeTests.TestRemoveFirst(test_deque);
        DequeTests.TestRemoveLast(test_deque);
        Console.WriteLine();
        DequeTests.TestIterator(test_deque);
    }
}

public class DequeTests
{
    public static bool TestConstructor()
    {
        Deque<int> deque = new Deque<int>();

        int expected1 = 0;
        int actual1 = deque.Size();

        bool expected2 = true;
        bool actual2 = deque.IsEmpty();

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

    public static bool TestAddFirst(Deque<int> test_deque)
    {
        test_deque.AddFirst(1);
        int expected1 = 1;
        int actual1 = test_deque.Size();

        test_deque.AddFirst(2);
        int expected2 = 2;
        int actual2 = test_deque.Size();

        test_deque.AddFirst(0);
        int expected3 = 3;
        int actual3 = test_deque.Size();

        bool expected = false;
        bool actual = test_deque.IsEmpty();

        if (actual1 != expected1)
        {
            Console.WriteLine("TestAddFirst: case1 FAILED");
            return false;
        }
        if (actual2 != expected2)
        {
            Console.WriteLine("TestAddFirst: case2 FAILED");
            return false;
        }
        if (actual3 != expected3)
        {
            Console.WriteLine("TestAddFirst: case3 FAILED");
            return false;
        }
        if (actual != expected)
        {
            Console.WriteLine("TestAddFirst: case4 FAILED");
            return false;
        }

        Console.WriteLine("TestAddFirst: all cases PASSED");
        return true;
    }

    public static bool TestAddLast(Deque<int> test_deque)
    {
        test_deque.AddLast(7);
        int expected1 = 4;
        int actual1 = test_deque.Size();

        test_deque.AddLast(91);
        int expected2 = 5;
        int actual2 = test_deque.Size();

        test_deque.AddLast(5);
        int expected3 = 6;
        int actual3 = test_deque.Size();

        bool expected = false;
        bool actual = test_deque.IsEmpty();

        if (actual1 != expected1)
        {
            Console.WriteLine("TestAddLast: case1 FAILED");
            return false;
        }
        if (actual2 != expected2)
        {
            Console.WriteLine("TestAddLast: case2 FAILED");
            return false;
        }
        if (actual3 != expected3)
        {
            Console.WriteLine("TestAddLast: case3 FAILED");
            return false;
        }
        if (actual != expected)
        {
            Console.WriteLine("TestAddLast: case4 FAILED");
            return false;
        }

        Console.WriteLine("TestAddLast: all cases PASSED");
        return true;
    }

    public static bool TestRemoveFirst(Deque<int> test_deque)
    {
        int expected1 = 0;
        int actual1 = test_deque.RemoveFirst();

        int expected2 = 2;
        int actual2 = test_deque.RemoveFirst();

        int expected = 4;
        int actual = test_deque.Size();

        if (actual1 != expected1)
        {
            Console.WriteLine("TestRemoveFirst: case1 FAILED");
            return false;
        }
        if (actual2 != expected2)
        {
            Console.WriteLine("TestRemoveFirst: case2 FAILED");
            return false;
        }
        if (actual != expected)
        {
            Console.WriteLine("TestRemoveFirst: case3 FAILED");
            return false;
        }

        Console.WriteLine("TestRemoveFirst: all cases PASSED");
        return true;
    }

    public static bool TestRemoveLast(Deque<int> test_deque)
    {
        int expected1 = 5;
        int actual1 = test_deque.RemoveLast();

        int expected2 = 91;
        int actual2 = test_deque.RemoveLast();

        int expected = 2;
        int actual = test_deque.Size();

        if (actual1 != expected1)
        {
            Console.WriteLine("TestRemoveLast: case1 FAILED");
            return false;
        }
        if (actual2 != expected2)
        {
            Console.WriteLine("TestRemoveLast: case2 FAILED");
            return false;
        }
        if (actual != expected)
        {
            Console.WriteLine("TestRemoveLast: case3 FAILED");
            return false;
        }

        Console.WriteLine("TestRemoveLast: all cases PASSED");
        return true;
    }

    public static void TestIterator(Deque<int> test_deque)
    {
        Console.WriteLine("Testing Iterator()...");

        test_deque.AddFirst(12);
        test_deque.AddLast(20);

        Console.Write("Items in order from front to back: ");

        IIterator<int> iterator = test_deque.Iterator();
        while (iterator.HasNext)
        {
            Console.Write(iterator.MoveNext() + " ");
        }

        //expected result:
        //  Items in order from front to back: 12 1 7 20
    }
}