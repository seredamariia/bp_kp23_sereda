using System;

interface IVessel
{
    void PrepareToMoving();
    void Move();
}

class SailingVessel : IVessel
{
    public void PrepareToMoving()
    {
        Console.WriteLine("Preparing the sails for movement...");
    }

    public void Move()
    {
        Console.WriteLine("Sailing away!");
    }
}

class Submarine : IVessel
{
    public void PrepareToMoving()
    {
        Console.WriteLine("Diving underwater...");
    }

    public void Move()
    {
        Console.WriteLine("Submerged and moving forward!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SailingVessel sailingVessel = new SailingVessel();
        Submarine submarine = new Submarine();

        sailingVessel.PrepareToMoving();
        sailingVessel.Move();

        Console.WriteLine();

        submarine.PrepareToMoving();
        submarine.Move();
    }
}
