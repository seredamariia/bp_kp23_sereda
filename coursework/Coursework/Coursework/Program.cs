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
        FullName = fullName;
        BirthYear = birthYear;
        Height = height;
        Weight = weight;
        Citizenship = citizenship;
        Sport = sport;
        SportCategory = sportCategory;
        Club = club;
        PersonalRecord = personalRecord;
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
        Console.WriteLine($"{FullName,-30}{BirthYear,-7}{Height,-3} cm   {Weight,-3} kg   {Citizenship,-15}{Sport,-20}{SportCategory,-20}{Club,-32}{PersonalRecord,-5} sec");
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
        Console.WriteLine($"{FullName,-30}{BirthYear,-7}{Height,-3} cm   {Weight,-3} kg   {Citizenship,-15}{Sport,-20}{SportCategory,-20}{Club,-32}{PersonalRecord,-5} points");
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
        Console.WriteLine($"{FullName,-30}{BirthYear,-7}{Height,-3} cm   {Weight,-3} kg   {Citizenship,-15}{Sport,-20}{SportCategory,-20}{Club,-32}{PersonalRecord,-5} points");
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
        Console.WriteLine($"{FullName,-30}{BirthYear,-7}{Height,-3} cm   {Weight,-3} kg   {Citizenship,-15}{Sport,-20}{SportCategory,-20}{Club,-32}{PersonalRecord,-5} m");
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
        Console.WriteLine($"{FullName,-30}{BirthYear,-7}{Height,-3} cm   {Weight,-3} kg   {Citizenship,-15}{Sport,-20}{SportCategory,-20}{Club,-32}{PersonalRecord,-5} m");
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
        Console.WriteLine($"{FullName,-30}{BirthYear,-7}{Height,-3} cm   {Weight,-3} kg   {Citizenship,-15}{Sport,-20}{SportCategory,-20}{Club,-32}{PersonalRecord,-5} h");
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
        Console.WriteLine($"{FullName,-30}{BirthYear,-7}{Height,-3} cm   {Weight,-3} kg   {Citizenship,-15}{Sport,-20}{SportCategory,-20}{Club,-32}{PersonalRecord,-5} m");
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
        sportsmen = new List<Sportsman>();
    }

    public void LoadFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                string fullName = data[0];
                int birthYear = int.Parse(data[1]);
                int height = int.Parse(data[2].Trim().Replace("cm", ""));
                int weight = int.Parse(data[3].Trim().Replace("kg", ""));
                string citizenship = data[4];
                string sport = data[5];
                string sportCategory = data[6];
                string club = data[7];
                string personalRecordData = data[8];
                string personalRecord = "";
                int i = 0;
                while (personalRecordData[i] != ' ')
                {
                    personalRecord += personalRecordData[i];
                    i++;
                }

                Sportsman sportsman = CreateSportsman(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                sportsmen.Add(sportsman);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred while loading data: " + e.Message);
        }
    }

    private Sportsman CreateSportsman(string fullName, int birthYear, int height, int weight, string citizenship, string sport, string sportCategory, string club, string personalRecord)
    {
        switch (sport.ToLower())
        {
            case "swimming":
                if (sportCategory.ToLower() == "50 m swimming")
                {
                    return new FiftyMeter_Swimmer(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "100 m swimming")
                {
                    return new OneHundredMeter_Swimmer(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else
                {
                    return new Swimmer(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }

            case "figure skating":
                if (sportCategory.ToLower() == "combined total")
                {
                    return new CombinedTotal_FigureSkater(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "short program")
                {
                    return new ShortProgram_FigureSkater(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "free skating")
                {
                    return new FreeSkating_FigureSkater(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else
                {
                    return new FigureSkater(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }

            case "athletics":
                if (sportCategory.ToLower() == "decathlon")
                {
                    return new Decathlete(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "shot put")
                {
                    return new ShotPut_Athlete(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "pole vault")
                {
                    return new PoleVault_Athlete(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "marathon")
                {
                    return new MarathonRunner(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "long jump")
                {
                    return new LongJump_Athlete(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else if (sportCategory.ToLower() == "high jump")
                {
                    return new HighJump_Athlete(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }
                else
                {
                    return new Athlete(fullName, birthYear, height, weight, citizenship, sport, sportCategory, club, personalRecord);
                }

            default:
                throw new NotSupportedException($"Sportsman type for sport '{sport}' is not supported.");
        }
    }

    public void DisplaySportsmenByName(string fullName)
    {
        Console.WriteLine($"Information about {fullName.Trim().ToUpper()}:");
        foreach (Sportsman sportsman in sportsmen)
        {
            if (sportsman.FullName.ToLower().Contains(fullName.Trim().ToLower()))
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenByAge(string ageGap)
    {
        string[] ages = ageGap.Split('-');

        if (ages.Length != 2)
        {
            Console.WriteLine("Invalid age gap format. Please use the format 'minAge - maxAge'.");
            return;
        }

        if (!int.TryParse(ages[0].Trim(), out int minAge) || !int.TryParse(ages[1].Trim(), out int maxAge))
        {
            Console.WriteLine("Invalid age gap format. Please provide numeric values for minAge and maxAge.");
            return;
        }

        Console.WriteLine($"Sportsmen between {minAge} and {maxAge} years old:");

        foreach (Sportsman sportsman in sportsmen)
        {
            int currentAge = DateTime.Now.Year - sportsman.BirthYear;
            if ((minAge <= maxAge && currentAge >= minAge && currentAge <= maxAge) || (minAge >= maxAge && currentAge <= minAge && currentAge >= maxAge))
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenByAge(int age)
    {
        Console.WriteLine($"Sportsmen of {age} years old:");

        foreach (Sportsman sportsman in sportsmen)
        {
            int currentAge = DateTime.Now.Year - sportsman.BirthYear;
            if (currentAge == age)
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenByHeight(string heightGap)
    {
        string[] heights = heightGap.Split('-');

        if (heights.Length != 2)
        {
            Console.WriteLine("Invalid weight gap format. Please use the format 'minHeight - maxHeight'.");
            return;
        }

        if (!int.TryParse(heights[0].Trim(), out int minHeight) || !int.TryParse(heights[1].Trim(), out int maxHeight))
        {
            Console.WriteLine("Invalid weight gap format. Please provide numeric values for minHeight and maxHeight.");
            return;
        }

        Console.WriteLine($"Sportsmen between {minHeight} and {maxHeight} cm:");

        foreach (Sportsman sportsman in sportsmen)
        {
            if ((minHeight <= maxHeight && sportsman.Height >= minHeight && sportsman.Height <= maxHeight) || (minHeight >= maxHeight && sportsman.Height <= minHeight && sportsman.Height >= maxHeight))
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenByWeight(string weightGap)
    {
        string[] weights = weightGap.Split('-');

        if (weights.Length != 2)
        {
            Console.WriteLine("Invalid weight gap format. Please use the format 'minWeight - maxWeight'.");
            return;
        }

        if (!int.TryParse(weights[0].Trim(), out int minWeight) || !int.TryParse(weights[1].Trim(), out int maxWeight))
        {
            Console.WriteLine("Invalid weight gap format. Please provide numeric values for minWeight and maxWeight.");
            return;
        }

        Console.WriteLine($"Sportsmen between {minWeight} and {maxWeight} kg:");

        foreach (Sportsman sportsman in sportsmen)
        {
            if ((minWeight <= maxWeight && sportsman.Weight >= minWeight && sportsman.Weight <= maxWeight) || (minWeight >= maxWeight && sportsman.Weight <= minWeight && sportsman.Weight >= maxWeight))
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenByCitizenship(string citizenship)
    {
        var filteredSportsmen = sportsmen.FindAll(s => s.Citizenship.ToLower() == citizenship.Trim().ToLower());

        if (filteredSportsmen.Count == 0)
        {
            Console.WriteLine($"No sportsmen found with the nationality '{citizenship.Trim().ToUpper()}'.");
        }
        else
        {
            Console.WriteLine($"Sportsmen with {citizenship.Trim().ToUpper()} citizenship:");
            foreach (Sportsman sportsman in filteredSportsmen)
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenBySport(string sport)
    {
        Console.WriteLine($"Sportsmen doing {sport.Trim().ToUpper()}:");
        foreach (Sportsman sportsman in sportsmen)
        {
            if (sportsman.Sport.ToLower() == sport.Trim().ToLower())
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenBySportCategory(string sportCategory)
    {
        Console.WriteLine($"Sportsmen doing {sportCategory.Trim().ToUpper()}:");
        foreach (Sportsman sportsman in sportsmen)
        {
            if (sportsman.SportCategory.ToLower() == sportCategory.Trim().ToLower())
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplaySportsmenByClub(string club)
    {
        Console.WriteLine($"Sportsmen from {club.Trim().ToUpper()} club:");
        foreach (Sportsman sportsman in sportsmen)
        {
            if (sportsman.Club.ToLower().Contains(club.Trim().ToLower()))
            {
                sportsman.DisplayDetails();
            }
        }
        Console.WriteLine();
    }

    public void DisplayRecordHolder(string sportCategory)
    {
        if (sportCategory == "50 m swimming" || sportCategory == "100 m swimming" || sportCategory == "marathon")
        {
            var recordHolder = sportsmen
                .Where(s => s.SportCategory == sportCategory.Trim().ToLower())
                .OrderBy(s => s.PersonalRecord)
                .FirstOrDefault();

            if (recordHolder != null)
            {
                Console.WriteLine($"Record holder in {sportCategory.Trim().ToUpper()}:");
                recordHolder.DisplayDetails();
            }
            else
            {
                Console.WriteLine($"No record holder found in {sportCategory.Trim().ToUpper()}.");
            }
        }
        else
        {
            var recordHolder = sportsmen
                .Where(s => s.SportCategory == sportCategory.Trim().ToLower())
                .OrderByDescending(s => s.PersonalRecord)
                .FirstOrDefault();

            if (recordHolder != null)
            {
                Console.WriteLine($"Record holder in {sportCategory.Trim().ToUpper()}:");
                recordHolder.DisplayDetails();
            }
            else
            {
                Console.WriteLine($"No record holder found in {sportCategory.Trim().ToUpper()}.");
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        /*fanGuide.DisplaySportsmenByCitizenship("New Zealand");;*/
        /*fanGuide.DisplaySportsmenByClub("Griffith University");*/
        /*fanGuide.DisplaySportsmenByWeight("80 - 70");*/
        /*fanGuide.DisplaySportsmenBySportCategory("100 m SWIMMING");
        fanGuide.DisplaySportsmenBySport("SWIMMING");*/

        /*fanGuide.FindRecordHolder("swimming", "fastest");*/
        /*fanGuide.DisplayRecordHolder("100 m swimming");*/

        /*Console.ReadLine();*/

        FanGuide fanGuide = new FanGuide();
        fanGuide.LoadFromFile("C:\\Users\\Марія\\KPI\\1 курс\\OP\\bp_kp23_sereda\\coursework\\Coursework\\Coursework\\sportsmen-data.txt");

        Console.WriteLine("Welcome to the Sportsmen Fan Guide!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Search sportsmen's data by sportsmen name");
        Console.WriteLine("2. Search sportsmen's data by sportsmen age");
        Console.WriteLine("3. Search sportsmen's data by sportsmen height");
        Console.WriteLine("4. Search sportsmen's data by sportsmen weight");
        Console.WriteLine("5. Search sportsmen's data by sportsmen citizenship");
        Console.WriteLine("6. Search sportsmen's data by sportsmen sport");
        Console.WriteLine("7. Search sportsmen's data by sportsmen sport category");
        Console.WriteLine("8. Search sportsmen's data by sportsmen club");
        Console.WriteLine("9. Search record holder in specific category");
        Console.WriteLine("10. Exit" + "\n");

        bool exit = false;

        while (!exit)
        {
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter sportsmen's name: ");
                    string name = Console.ReadLine().Trim();
                    fanGuide.DisplaySportsmenByName(name);
                    break;

                case "2":
                    Console.Write("Enter sporstmen's age (in the format [minAge - maxAge] or in the format [age]): ");
                    string age = Console.ReadLine().Trim();

                    if (int.TryParse(age, out int intAge))
                    {
                        fanGuide.DisplaySportsmenByAge(intAge);
                    }
                    else
                    {
                        fanGuide.DisplaySportsmenByAge(age);
                    }
                    break;

                case "3":
                    Console.Write("Enter sportsmen's height gap in the format [minHeight - maxHeight]: ");
                    string height = Console.ReadLine().Trim();
                    fanGuide.DisplaySportsmenByHeight(height);
                    break;

                case "4":
                    Console.Write("Enter sportsmen's weight gap in the format [minWeight - maxWeight]: ");
                    string weight = Console.ReadLine().Trim();
                    fanGuide.DisplaySportsmenByWeight(weight);
                    break;

                case "5":
                    Console.Write("Enter sportsmen's citizenhip: ");
                    string citizenhip = Console.ReadLine().Trim();
                    fanGuide.DisplaySportsmenByCitizenship(citizenhip);
                    break;

                case "6":
                    Console.Write("Enter sportsmen's sport: ");
                    string sport = Console.ReadLine().Trim();
                    fanGuide.DisplaySportsmenBySport(sport);
                    break;

                case "7":
                    Console.Write("Enter sportsmen's sport category: ");
                    string sportCategory = Console.ReadLine().Trim();
                    fanGuide.DisplaySportsmenBySportCategory(sportCategory);
                    break;

                case "8":
                    Console.Write("Enter sportsmen's club: ");
                    string club = Console.ReadLine().Trim();
                    fanGuide.DisplaySportsmenByClub(club);
                    break;

                case "9":
                    Console.Write("Enter sport category: ");
                    string sportCategoryRecord = Console.ReadLine().Trim();
                    fanGuide.DisplayRecordHolder(sportCategoryRecord);
                    break;

                case "10":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Sportsmen Fan Guide!");
    }
}
