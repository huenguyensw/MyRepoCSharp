namespace EmployeeManagement.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void EmployeeDisplay_ReturnCorrectResult()
        {
            // Arrange
            var register = new RegisterEmployee();
            register.AddEmployee("John Doe", 50000m);
            register.AddEmployee("Jane Smith", 60000m);
            // Act
            var employees = register.GetEmployee();
            // Assert
            Assert.Equal(2, employees.Count);
            Assert.Equal("John Doe", employees[0].Name);
            Assert.Equal(50000m, employees[0].Salary);
            Assert.Equal("Jane Smith", employees[1].Name);
            Assert.Equal(60000m, employees[1].Salary);

        }
    }
}
