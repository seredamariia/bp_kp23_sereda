using System;

class Employee
{
    private int id;
    private string surname;
    private decimal salary;
    private decimal withheld;
    private decimal issued;

    public Employee(int id, string surname, decimal salary, decimal withheld)
    {
        this.id = id;
        this.surname = surname;
        this.salary = salary;
        this.withheld = withheld;
    }

    public decimal GetSalary()
    {
        return salary;
    }

    public decimal GetWithheld()
    {
        return withheld;
    }

    public decimal Issued()
    {
        return issued;
    }

    public override string ToString()
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}