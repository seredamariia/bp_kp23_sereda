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
        issued = salary - withheld;
        return issued;
    }

    public override string ToString()
    {
        return $"{id,-2} {surname,-10} {salary,10:N2} {withheld,10:N2} {Issued(),10:N2}";
    }
}

class Payroll
{
    

    public Payroll(Employee[] employees)
    {
        
    }

    public void DisplayPayroll()
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many employees do you want to include on the payroll?");
        int n = Convert.ToInt32(Console.ReadLine());
        Employee[] employees = new Employee[n];

        Console.WriteLine("\nEnter employees data (FORMAT OF THE DATA: SURNAME SALARY WITHHELD):");

        for (int i = 0; i < employees.Length; i++)
        {
            string[] input = Console.ReadLine().Split();
            int id = i + 1;
            string surname = input[0];
            decimal salary = decimal.Parse(input[1]);
            decimal withheld = decimal.Parse(input[2]);
            employees[i] = new Employee(id, surname, salary, withheld);
        }

        Payroll payroll = new Payroll(employees);
        payroll.DisplayPayroll();
    }
}
