using System;

abstract class Vessel
{
    public abstract void PrepareToMoving();
    public abstract void Move();
}

class SailingVessel : Vessel
{
    public override void PrepareToMoving()
    {
        Console.WriteLine("Preparing the sails...");
    }

    public override void Move()
    {
        Console.WriteLine("Sailing away!");
    }
}

class Submarine : Vessel
{
    public override void PrepareToMoving()
    {
        Console.WriteLine("Diving underwater...");
    }

    public override void Move()
    {
        Console.WriteLine("Submerged and moving forward!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vessel vessel1 = new SailingVessel();
        Vessel vessel2 = new Submarine();

        vessel1.PrepareToMoving();
        vessel1.Move();

        Console.WriteLine();

        vessel2.PrepareToMoving();
        vessel2.Move();
    }
}
