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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many employees do you want to include on the payroll?");
        int n = Convert.ToInt32(Console.ReadLine());
        Employee[] employees = new Employee[n];

        Console.WriteLine("\nEnter employees data (FORMAT OF THE DATA: SURNAME SALARY WITHHELD):");

        /*test cases:
            case 1: n = 0
            case 2: n = 1
                    Employees data:
                                    Melnyk 10000 1000
            case 3: n = 3
                    Employees data:
                                    Kubrak 15000 500
                                    Malyshev 12500 750
                                    Kochetkova 20000 0
         */

        for (int i = 0; i < employees.Length; i++)
        {
            string[] input = Console.ReadLine().Split();
            int id = i + 1;
            string surname = input[0];
            decimal salary = decimal.Parse(input[1]);
            decimal withheld = decimal.Parse(input[2]);
            employees[i] = new Employee(id, surname, salary, withheld);
        }

        Console.WriteLine("\nEmployees data:");

        Console.WriteLine($"{"#",-2} {"Surname",-10} {"Salary",10} {"Withheld",10} {"Issued",10}");

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }

        decimal totalSalary = 0, totalWithheld = 0, totalIssued = 0;

        foreach (Employee employee in employees)
        {
            totalSalary += employee.GetSalary();
            totalWithheld += employee.GetWithheld();
            totalIssued += employee.Issued();
        }

        Console.WriteLine($"\n{"",-2} {"Total",-10} {totalSalary,10:N2} {totalWithheld,10:N2} {totalIssued,10:N2}");

        /*test cases:
            case 1: #  Surname        Salary   Withheld     Issued

                       Total            0,00       0,00       0,00
            case 2: #  Surname        Salary   Withheld     Issued
                    1  Melnyk      10 000,00   1 000,00   9 000,00

                       Total       10 000,00   1 000,00   9 000,00
            case 3: #  Surname        Salary   Withheld     Issued
                    1  Kubrak      15 000,00     500,00  14 500,00
                    2  Malyshev    12 500,00     750,00  11 750,00
                    3  Kochetkova  20 000,00       0,00  20 000,00

                       Total       47 500,00   1 250,00  46 250,00
         */
    }
}