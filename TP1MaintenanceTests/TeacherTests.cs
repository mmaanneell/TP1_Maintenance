using Xunit;
using Members;

namespace TP1MaintenanceTests;

public class TeacherTests
{

    [Fact]
    public void Constructor_WithValidSubject()
    {

        string name = "Mathieu";
        string address = "Montreal";
        int phoneNumber = 5551234;
        int income = 30000;
        string subject = "IT";

        Teacher teacher = new Teacher(name, address, phoneNumber, income, subject);

        Assert.Equal(name, teacher.Name);
        Assert.Equal(address, teacher.Address);
        Assert.Equal(phoneNumber, teacher.PhoneNumber);
        Assert.Equal(income, teacher.Income);
        Assert.Equal(subject, teacher.Subject);
        Assert.Equal(0, teacher.Balance);
    }

    [Fact]
    public void Constructor_WithEmptySubject()
    {
        string name = "Manel";
        string address = "Laval";
        int phoneNumber = 9999999;
        int income = 27000;
        string subject = "";

        Teacher teacher = new Teacher(name, address, phoneNumber, income, subject);

        Assert.Equal("DefaultSubject", teacher.Subject);
    }

    [Fact]
    public void Constructor_ShouldAddTeacherToList()
    {
        Teacher.Teachers.Clear();
        int initialCount = Teacher.Teachers.Count;

        Teacher teacher = new Teacher("Sam", "Repentigny", 5550000, 28000, "History");

        Assert.Contains(teacher, Teacher.Teachers);
        Assert.Equal(initialCount + 1, Teacher.Teachers.Count);
    }

    [Fact]
    public void Constructor_WithoutIncome()
    {
        Teacher.Teachers.Clear();
        int expectedIncome = 25000;

        Teacher teacher = new Teacher("Alice", "Longueuil", 1234567, subject: "Science");

        Assert.Equal(expectedIncome, teacher.Income);
    }

    [Fact]
    public void Pay_IncreaseBalanceByIncome()
    {
        Teacher teacher = new Teacher("Francois", "Montreal", 5551234, 2000, "Math");
        int initialBalance = teacher.Balance;

        teacher.Pay();

        Assert.Equal(initialBalance + teacher.Income, teacher.Balance);
    }
    [Fact]
    public void PayAll_IncreaseBalanceOfAllTeachers()
    {

        Teacher.Teachers.Clear(); 
        Teacher teacher1 = new Teacher("Nadine", "Montreal", 5551234, 1500, "Math");
        Teacher teacher2 = new Teacher("Manel", "Laval", 5555678, 2500, "Science");
        Teacher teacher3 = new Teacher("Samentha", "Repentigny", 5559999, 3000, "English");

        int balance1 = teacher1.Balance;
        int balance2 = teacher2.Balance;
        int balance3 = teacher3.Balance;


        Teacher.PayAll();

        Assert.Equal(balance1 + teacher1.Income, teacher1.Balance);
        Assert.Equal(balance2 + teacher2.Income, teacher2.Balance);
        Assert.Equal(balance3 + teacher3.Income, teacher3.Balance);
    }
    [Fact]
    public void PayAll_HandleEmptyTeacherList()
    {

        Teacher.Teachers.Clear();

        var exception = Record.Exception(() => Teacher.PayAll());
        Assert.Null(exception);
    }


}






