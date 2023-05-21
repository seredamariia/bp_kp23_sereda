using System;

public class Deque<Item> : IIterator<Item>
{
    public Deque()
    {
        
    }

    public bool IsEmpty()
    {
        
    }

    public int Size()
    {
        
    }

    public void AddFirst(Item item)
    {
        
    }

    public void AddLast(Item item)
    {
        
    }

    public Item RemoveFirst()
    {
        
    }

    public Item RemoveLast()
    {
        
    }

    public IIterator<Item> Iterator()
    {
        
    }

    public bool HasNext;

    public Item MoveNext()
    {
        
    }

    private void Resize(int newCapacity)
    {
        
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
        
    }
}