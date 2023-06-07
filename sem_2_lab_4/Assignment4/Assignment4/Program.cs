using System;
using System.Collections.Generic;
using System.IO;

public class HashTable<KItem, VItem>
{
    private const int DefaultCapacity = 51;
    private LinkedList<KeyValuePair<KItem, VItem>>[] buckets;

    public HashTable()
    {
        buckets = new LinkedList<KeyValuePair<KItem, VItem>>[DefaultCapacity];
    }

    public HashTable(int initialCapacity)
    {
        buckets = new LinkedList<KeyValuePair<KItem, VItem>>[initialCapacity];
    }

    private int GetBucketIndex(KItem key)
    {
        int hashCode = Math.Abs(key.GetHashCode());
        int bucketIndex = hashCode % buckets.Length;
        return bucketIndex;
    }

    public void Add(KItem key, VItem value)
    {
        int bucketIndex = GetBucketIndex(key);

        if (buckets[bucketIndex] == null)
            buckets[bucketIndex] = new LinkedList<KeyValuePair<KItem, VItem>>();

        foreach (var pair in buckets[bucketIndex])
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("An element with the same key already exists.");
            }
        }

        buckets[bucketIndex].AddLast(new KeyValuePair<KItem, VItem>(key, value));
    }

    public void Remove(KItem key)
    {
        int bucketIndex = GetBucketIndex(key);

        if (buckets[bucketIndex] != null)
        {
            var node = buckets[bucketIndex].First;

            while (node != null)
            {
                if (node.Value.Key.Equals(key))
                {
                    buckets[bucketIndex].Remove(node);
                    return;
                }

                node = node.Next;
            }
        }
    }

    public VItem Get(KItem key)
    {
        int bucketIndex = GetBucketIndex(key);

        if (buckets[bucketIndex] != null)
        {
            foreach (var pair in buckets[bucketIndex])
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }
        }

        throw new KeyNotFoundException("The given key was not found in the hash table.");
    }

    public bool Contains(KItem key)
    {
        int bucketIndex = GetBucketIndex(key);

        if (buckets[bucketIndex] != null)
        {
            foreach (var pair in buckets[bucketIndex])
            {
                if (pair.Key.Equals(key))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void Clear()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i]?.Clear();
        }
    }

    public int Size()
    {
        int count = 0;

        for (int i = 0; i < buckets.Length; i++)
        {
            count += buckets[i]?.Count ?? 0;
        }

        return count;
    }
}

public class Program
{
    public static void Main()
    {
        HashTable<string, bool> dictionary = new HashTable<string, bool>();

        // Read words from text file and add them to the dictionary
        string[] words = File.ReadAllLines("C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\sem_2_lab_4\\Assignment4\\Assignment4\\words.txt");
        foreach (string word in words)
        {
            dictionary.Add(word, true);
        }

        while (true)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine().Trim();

            if (dictionary.Contains(word))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Wrong Spelling");
            }
        }

        /* test cases:
            case 1: pie
            case 2: piee
            case 3: cabinet
            case 4: cabine
            case 5: cat */

        /* test cases:
            case 1: OK
            case 2: Wrong Spelling
            case 3: OK
            case 4: Wrong Spelling
            case 5: Wrong Spelling */
    }
}