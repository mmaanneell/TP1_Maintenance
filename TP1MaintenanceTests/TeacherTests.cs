using Xunit;
using Members;
using Managers;

namespace TP1MaintenanceTests;

public class TeacherTests
{
    static TeacherTests()
    {
        JSONConfigurationManager.Initialize();
    }

    [Fact]
    public void Constructor_WithValidSubject()
    {
        string name = "Mathieu";
        string address = "Montreal";
        int phoneNumber = 5551234;
        string subject = "IT";

        Teacher teacher = new Teacher(name, address, phoneNumber, subject);

        Assert.Equal(name, teacher.Name);
        Assert.Equal(address, teacher.Address);
        Assert.Equal(phoneNumber, teacher.PhoneNumber);
        Assert.Equal(JSONConfigurationManager.SalarySettings.Teacher, teacher.Income);
        Assert.Equal(subject, teacher.Subject);
        Assert.Equal(0, teacher.Balance);
    }

    [Fact]
    public void Constructor_WithEmptySubject()
    {
        string name = "Manel";
        string address = "Laval";
        int phoneNumber = 9999999;
        string subject = "";

        Teacher teacher = new Teacher(name, address, phoneNumber, subject);

        Assert.Equal("DefaultSubject", teacher.Subject);
    }

    [Fact]
    public void Constructor_ShouldAddTeacherToList()
    {
        Teacher.Teachers.Clear();
        int initialCount = Teacher.Teachers.Count;

        Teacher teacher = new Teacher("Sam", "Repentigny", 5550000, "History");

        Assert.Contains(teacher, Teacher.Teachers);
        Assert.Equal(initialCount + 1, Teacher.Teachers.Count);
    }

    [Fact]
    public void Constructor_WithoutIncome()
    {
        Teacher.Teachers.Clear();
        int expectedIncome = 25000;

        Teacher teacher = new Teacher("Alice", "Longueuil", 1234567, "Science");

        Assert.Equal(expectedIncome, teacher.Income);
    }
    [Fact]
    public void Pay_ShouldIncreaseBalanceByIncome()
    {

        Teacher teacher = new Teacher("Nadine", "Montreal", 5551234, "Math");
        int initialBalance = teacher.Balance;


        teacher.Pay();

        Assert.Equal(initialBalance + teacher.Income, teacher.Balance);
    }

}
