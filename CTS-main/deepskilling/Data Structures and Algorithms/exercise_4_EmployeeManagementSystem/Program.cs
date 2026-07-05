using System;

class Program
{
    static void Main()
    {
        EmployeeManagement management = new EmployeeManagement();

        management.AddEmployee(new Employee(101, "Rahul", "Manager", 50000));
        management.AddEmployee(new Employee(102, "Priya", "Developer", 40000));
        management.AddEmployee(new Employee(103, "Arjun", "Tester", 35000));

        management.TraverseEmployees();

        Console.WriteLine();

        management.SearchEmployee(102);

        Console.WriteLine();

        management.DeleteEmployee(102);

        management.TraverseEmployees();
    }
}
