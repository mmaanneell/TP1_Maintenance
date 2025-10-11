using Xunit;
using Members;

namespace TP1MaintenanceTests;

public class ReceptionistTests
{
    [Fact]
    public void Constructor_WithValidParameters()
    {
        string name = "Alice";
        string address = "Montreal";
        int phoneNumber = 5551234;
        int income = 12000;

        Receptionist receptionist = new Receptionist(name, address, phoneNumber, income);

        Assert.Equal(name, receptionist.Name);
        Assert.Equal(address, receptionist.Address);
        Assert.Equal(phoneNumber, receptionist.PhoneNumber);
        Assert.Equal(income, receptionist.Income);
        Assert.Equal(0, receptionist.Balance);
    }

    [Fact]
    public void Constructor_WithDefaultIncome()
    {
        string name = "Bob";
        string address = "Laval";
        int phoneNumber = 9876543;
        int expectedIncome = 10000;

        Receptionist receptionist = new Receptionist(name, address, phoneNumber);

        Assert.Equal(expectedIncome, receptionist.Income);
        Assert.Equal(0, receptionist.Balance);
        Assert.Equal(name, receptionist.Name);
        Assert.Equal(address, receptionist.Address);
        Assert.Equal(phoneNumber, receptionist.PhoneNumber);
    }

    [Fact]
    public void HandleComplaint_TriggerComplaintRaised()
    {
        Receptionist receptionist = new Receptionist("Nadine", "Montreal", 5551234, 12000);
        bool eventTriggered = false;

        receptionist.ComplaintRaised += (sender, complaint) =>
        {
            eventTriggered = true;
        };

        receptionist.HandleComplaint();

        Assert.True(eventTriggered);
    }
}
