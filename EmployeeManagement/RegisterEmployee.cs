public class RegisterEmployee
{
    private List<Employee> employees = new List<Employee>();
    public void AddEmployee(string name, decimal salary)
    {
        employees.Add(new Employee { Name = name, Salary = salary });
    }

    public List<Employee> GetEmployee()
    {
        return employees;
    }


    //public void PrintEmployees()
    //{
    //    for (int i = 0; i < employees.Count; i++)
    //    {
    //        Console.WriteLine($"Employee {i + 1}: Name = {employees[i].Name}, Salary = {employees[i].Salary}");
    //    }
    //}

    //Remove all employees with the given name
    public void RemoveEmployeeByName (string name)
    {
        employees.RemoveAll(e => e.Name == name);
    }

    //Caculate the average salary of all employees
    public decimal CalculateAverageOfSalary()
    {
        if (employees.Count == 0)
        {
            return 0;
        }
        else
        {
            return employees.Average(e => e.Salary);
        }
    }

    //Arrange employees by name in alphabetical order
    public List<Employee> ArrangeEmployeesByName()
    {
        return employees.OrderBy(e => e.Name).ToList();
    }

    //Print out employees to a text file
    public void PrintEmployeesToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < employees.Count; i++)
            {
                writer.WriteLine($"Employee {i + 1}: Name = {employees[i].Name}, Salary = {employees[i].Salary}");
            }
        }
    }
}