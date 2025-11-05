using System;
namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Registration System");
            // Additional code for employee registration can be added here

            RegisterEmployee register = new RegisterEmployee();


            while (true)
            {
                Console.WriteLine("Choose one option: 1- Register a new employee, 2- Display all employees, 3- Delete employees by name, " +
                    "4- Average of salary, 5-Arrange employees by name, 6- Print out to *.txt file, 0-Exit program...");
                var opt = Console.ReadLine();
                if (!int.TryParse(opt, out int parsedOpt))
                {
                    return;
                }

                switch (parsedOpt)
                {
                    case 1:
                        Console.WriteLine("Enter employee name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter employee salary:");
                        var salary = Console.ReadLine();
                        if (!decimal.TryParse(salary, out decimal parsedSalary))
                        {
                            Console.WriteLine("Invalid salary input. Please enter a valid decimal number.");
                            break;
                        }
                        if (parsedSalary < 0)
                        {
                            Console.WriteLine("Salary cannot be negative. Please enter a valid salary.");
                            break;
                        }
                        register.AddEmployee(name, parsedSalary);
                        break;
                    case 2:
                        List<Employee> employees = register.GetEmployee();
                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No employees registered.");
                        }
                        else
                        {
                            Console.WriteLine("List of employees:");
                            for (int i = 0; i < employees.Count; i++)
                            {
                                Console.WriteLine($"Employee {i + 1}: Name = {employees[i].Name}, Salary = {employees[i].Salary}");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the employee to remove:");
                        string selectedName = Console.ReadLine();
                        register.RemoveEmployeeByName(selectedName);
                        break;
                    case 4:
                        decimal averageSalary = register.CalculateAverageOfSalary();
                        Console.WriteLine($"The average of salary of employees is: {averageSalary}");
                        break;
                    case 5:
                        var arrangedEmployees = register.ArrangeEmployeesByName();
                        Console.WriteLine("New list after arranging:");
                        for (int i = 0; i < arrangedEmployees.Count; i++)
                        {
                            Console.WriteLine($"Employee {i + 1}: Name = {arrangedEmployees[i].Name}, Salary = {arrangedEmployees[i].Salary}");
                        }
                        break;
                    case 6:
                        string filepath = @"D:\C#\exported files\employees.txt";
                        register.PrintEmployeesToFile(filepath);
                        Console.WriteLine($"Employees have been printed to {filepath}");
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;
                }
            }


        }
    }
}