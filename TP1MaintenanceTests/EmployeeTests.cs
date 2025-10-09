namespace TP1MaintenanceTests;

public class EmployeeTests
{
    [Fact]
    public void Constructor_WhenValidParameters()
    {
        // Arrange
        string name = "Nadine dh";
        string address = "Montreal";
        int phoneNumber = 5551234;
        int income = 25000;

        // Act
        Employee employee = new Employee(name, address, phoneNumber, income);

        // Assert
        Assert.Equal(name, employee.Name);
        Assert.Equal(address, employee.Address);
        Assert.Equal(phoneNumber, employee.PhoneNumber);
        Assert.Equal(income, employee.Income);
        Assert.Equal(0, employee.Balance);
    }
        
        [Fact]
        public void Constructor_WhenNegativeIncome()
        {
            // Arrange
            string name = "Manel G";
            string address = "Laval";
            int phoneNumber = 9999999;
            int income = -1000;

            // Act
            Employee employee = new Employee(name, address, phoneNumber, income);

            // Assert
            Assert.Equal(0, employee.Income); 
            Assert.Equal(0, employee.Balance); 
            Assert.Equal(name, employee.Name);
            Assert.Equal(address, employee.Address);
            Assert.Equal(phoneNumber, employee.PhoneNumber);
        }
    }


