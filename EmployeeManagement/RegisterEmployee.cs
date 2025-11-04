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


    public void PrintEmployees()
    {
        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Name = {employees[i].Name}, Salary = {employees[i].Salary}");
        }
    }
}