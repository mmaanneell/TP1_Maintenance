using Xunit;
using Members;
using Managers;

namespace TP1MaintenanceTests;

public class PrincipalTests
{
    static PrincipalTests()
    {
        JSONConfigurationManager.Initialize();
    }

    [Fact]
    public void Constructor_WithValidParameters()
    {
        string name = "Nadine";
        string address = "Montreal";
        int phoneNumber = 5551234;

        Principal principal = new Principal(name, address, phoneNumber);

        Assert.Equal(name, principal.Name);
        Assert.Equal(address, principal.Address);
        Assert.Equal(phoneNumber, principal.PhoneNumber);
        Assert.Equal(JSONConfigurationManager.SalarySettings.Principal, principal.Income);
        Assert.Equal(0, principal.Balance);
    }

    [Fact]
    public void Constructor_WithDefaultIncome_()
    {

        string name = "Manel";
        string address = "Laval";
        int phoneNumber = 9999999;

        Principal principal = new Principal(name, address, phoneNumber);

        Assert.Equal(JSONConfigurationManager.SalarySettings.Principal, principal.Income);
        Assert.Equal(0, principal.Balance);
    }

}