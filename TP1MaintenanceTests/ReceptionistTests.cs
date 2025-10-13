using Xunit;
using Members;
using Managers;

namespace TP1MaintenanceTests;

public class ReceptionistTests
{
    [Fact]
    public void Constructor_WithValidParameters()
    {
        string name = "Alice";
        string address = "Montreal";
        int phoneNumber = 5551234;

        Receptionist receptionist = new Receptionist(name, address, phoneNumber);

        Assert.Equal(name, receptionist.Name);
        Assert.Equal(address, receptionist.Address);
        Assert.Equal(phoneNumber, receptionist.PhoneNumber);
        Assert.Equal(JSONConfigurationManager.SalarySettings.Receptionist, receptionist.Income);
        Assert.Equal(0, receptionist.Balance);
    }

    [Fact]
    public void Constructor_WithDefaultIncome()
    {
        string name = "Bob";
        string address = "Laval";
        int phoneNumber = 9876543;

        Receptionist receptionist = new Receptionist(name, address, phoneNumber);

        Assert.Equal(JSONConfigurationManager.SalarySettings.Receptionist, receptionist.Income);
        Assert.Equal(0, receptionist.Balance);
        Assert.Equal(name, receptionist.Name);
        Assert.Equal(address, receptionist.Address);
        Assert.Equal(phoneNumber, receptionist.PhoneNumber);
    }

    [Fact]
    public void HandleComplaint_TriggerComplaintRaised()
    {
        Receptionist receptionist = new Receptionist("Nadine", "Montreal", 5551234);
        bool eventTriggered = false;

        receptionist.ComplaintRaised += (sender, complaint) =>
        {
            eventTriggered = true;
        };

        receptionist.HandleComplaint();

        Assert.True(eventTriggered);
    }
}
