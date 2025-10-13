using Xunit;
using Members;
using Managers;

namespace TP1MaintenanceTests;

public class EmployeeTests
{
    static EmployeeTests()
    {
        JSONConfigurationManager.Initialize();
    }

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

    [Fact]
    public void Pay_AddsIncomeToBalance()
    {

        Employee employee = new Employee("Samentha", "Repentigny", 5551234, 2000);
        int initialBalance = employee.Balance;

        employee.Pay();

        Assert.Equal(initialBalance + 2000, employee.Balance);
    }

    [Fact]
    public void Pay_WithZeroIncome()
    {

        Employee employee = new Employee("Nadine", "MTL", 111, 0);


        employee.Pay();


        Assert.Equal(0, employee.Balance);
    }

}