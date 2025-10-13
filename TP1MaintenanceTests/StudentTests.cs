using Xunit;
using Members;
using Managers;

namespace TP1MaintenanceTests;

public class StudentTests
{
    static StudentTests()
    {
        JSONConfigurationManager.Initialize();
    }


    [Fact]
    public void Constructor_WithValidGrade()
    {

        string name = "Nadine";
        string address = "Montreal";
        int phoneNumber = 5551234;
        int grade = 85;

        Student student = new Student(name, address, phoneNumber, grade);

        Assert.Equal(name, student.Name);
        Assert.Equal(address, student.Address);
        Assert.Equal(phoneNumber, student.PhoneNumber);
        Assert.Equal(grade, student.Grade);
    }

    [Fact]
    public void Constructor_ShouldAddStudentToList()
    {

        Student.Students.Clear();
        int initialCount = Student.Students.Count;

        Student student = new Student("Sam", "Repentigny", 5550000, 90);

        Assert.Contains(student, Student.Students);
        Assert.Equal(initialCount + 1, Student.Students.Count);
    }

    [Fact]
    public void Constructor_WithInvalidGrade()
    {
        string name = "Manel";
        string address = "Laval";
        int phoneNumber = 9999999;
        int invalidGrade = -5;

        Student student = new Student(name, address, phoneNumber, invalidGrade);

        Assert.Equal(0, student.Grade);
    }

    [Fact]
    public void CalculateAverageGrade_WhenNoStudents()
    {

        Student.Students.Clear();

        double result = Student.CalculateAverageGrade();

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateAverageGrade_WithStudents()
    {
        Student.Students.Clear();
        new Student("Nadine", "MTL", 111, 80);
        new Student("Manel", "Laval", 222, 90);
        new Student("Samentha", "Longueuil", 333, 70);

        //(80 + 90 + 70) / 3 = 80
        double expectedAverage = 80;

        double result = Student.CalculateAverageGrade();

        Assert.Equal(expectedAverage, result, precision: 2);
    }
}