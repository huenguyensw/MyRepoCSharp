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
                Console.WriteLine("Choose one option: 1- Register a new employee, 2- Display all employees, 3-Exit program...");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 3)
                {
                    return;
                }

                switch (opt)
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
                        if(parsedSalary < 0)
                        {
                            Console.WriteLine("Salary cannot be negative. Please enter a valid salary.");
                            break;
                        }
                        register.AddEmployee(name, parsedSalary);
                        break;
                    case 2:
                        register.PrintEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;
                }
            }


        }
    }
}