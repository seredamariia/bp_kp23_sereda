using System;
using System.Diagnostics;

public class Deque<Item> : IIterator<Item>
{
    private class Node<T>
    {
        
    }

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
