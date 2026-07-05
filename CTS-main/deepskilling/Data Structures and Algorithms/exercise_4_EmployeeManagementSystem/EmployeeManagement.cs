using System;

public class EmployeeManagement
{
    private Employee[] employees = new Employee[10];
    private int count = 0;

    // Add Employee
    public void AddEmployee(Employee employee)
    {
        if (count < employees.Length)
        {
            employees[count] = employee;
            count++;
            Console.WriteLine("Employee Added Successfully");
        }
        else
        {
            Console.WriteLine("Employee Array is Full");
        }
    }

    // Search Employee
    public void SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                Console.WriteLine("Employee Found");
                employees[i].Display();
                return;
            }
        }

        Console.WriteLine("Employee Not Found");
    }

    // Traverse Employees
    public void TraverseEmployees()
    {
        Console.WriteLine("\nEmployee List");

        for (int i = 0; i < count; i++)
        {
            employees[i].Display();
        }
    }

    // Delete Employee
    public void DeleteEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                for (int j = i; j < count - 1; j++)
                {
                    employees[j] = employees[j + 1];
                }

                employees[count - 1] = null;
                count--;

                Console.WriteLine("Employee Deleted Successfully");
                return;
            }
        }

        Console.WriteLine("Employee Not Found");
    }
}
