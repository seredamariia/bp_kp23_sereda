using System;
using System.Collections.Generic;
using System.IO;

// Base class representing a sportsman (class #1)
public abstract class Sportsman
{
    public string FullName { get; }
    public int BirthYear { get; }
    public int Height { get; }
    public int Weight { get; }
    public string Citizenship { get; }
    public string Sport { get; }
    public string SportCategory { get; }
    public string Club { get; }
    public string PersonalRecord { get; }

    public Sportsman(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
    {

    }

    public abstract void DisplayDetails();
}

// Derived class representing a swimmer (class #2)
public class Swimmer : Sportsman
{
    public Swimmer(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }

    public override void DisplayDetails()
    {

    }
}

// Derived class representing a 50 m swimmer (class #3)
public class FiftyMeter_Swimmer : Swimmer
{
    public FiftyMeter_Swimmer(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}

// Derived class representing a 100 m swimmer (class #4)
public class OneHundredMeter_Swimmer : Swimmer
{
    public OneHundredMeter_Swimmer(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}


// Derived class representing a figure skater (class #5)
public class FigureSkater : Sportsman
{
    public FigureSkater(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }

    public override void DisplayDetails()
    {

    }
}

// Derived class representing a combined total figure skater (class #6)
public class CombinedTotal_FigureSkater : FigureSkater
{
    public CombinedTotal_FigureSkater(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}

// Derived class representing a short program figure skater (class #7)
public class ShortProgram_FigureSkater : FigureSkater
{
    public ShortProgram_FigureSkater(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}

// Derived class representing a short program figure skater (class #8)
public class FreeSkating_FigureSkater : FigureSkater
{
    public FreeSkating_FigureSkater(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}

// Derived class representing an athlete (class #9)
public class Athlete : Sportsman
{
    public Athlete(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }

    public override void DisplayDetails()
    {

    }
}

// Derived class representing a decathlete (class #10)
public class Decathlete : Athlete
{
    public Decathlete(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}

// Derived class representing a shot put athlete (class #11)
public class ShotPut_Athlete : Athlete
{
    public ShotPut_Athlete(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }

    public override void DisplayDetails()
    {

    }
}

// Derived class representing a pole vault athlete (class #12)
public class PoleVault_Athlete : Athlete
{
    public PoleVault_Athlete(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }

    public override void DisplayDetails()
    {

    }
}

// Derived class representing a marathon runner (class #13)
public class MarathonRunner : Athlete
{
    public MarathonRunner(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }

    public override void DisplayDetails()
    {

    }
}

// Derived class representing a jump athlete (class #14)
public class Jump_Athlete : Athlete
{
    public Jump_Athlete(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }

    public override void DisplayDetails()
    {

    }
}

// Derived class representing a jump athlete (class #15)
public class LongJump_Athlete : Jump_Athlete
{
    public LongJump_Athlete(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}

// Derived class representing a high athlete (class #16)
public class HighJump_Athlete : Jump_Athlete
{
    public HighJump_Athlete(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
        : base(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord)
    {
    }
}

// class #17
public class FanGuide
{
    private List<Sportsman> sportsmen;

    public FanGuide()
    {
        
    }

    public void LoadFromFile(string filePath)
    {
        
    }

    private Sportsman CreateSportsman(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
    {
        
    }

    public void DisplaySportsmenByName(string fullName)
    {
        
    }

    public void DisplaySportsmenByAge(string ageGap)
    {
        
    }

    public void DisplaySportsmenByAge(int age)
    {
        
    }

    public void DisplaySportsmenByHeight(string heightGap)
    {
        
    }

    public void DisplaySportsmenByWeight(string weightGap)
    {
        
    }

    public void DisplaySportsmenByCitizenship(string citizenship)
    {
        
    }

    public void DisplaySportsmenBySport(string sport)
    {
        
    }

    public void DisplaySportsmenBySportCategory(string sportCategory)
    {
        
    }

    public void DisplaySportsmenByClub(string club)
    {
        
    }

    public void DisplayRecordHolder(string sportCategory)
    {
        
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}
