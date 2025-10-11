using Xunit;
using Members;

namespace TP1MaintenanceTests;

public class PrincipalTests
{
    [Fact]
    public void Constructor_WithValidParameters()
    {
        string name = "Nadine";
        string address = "Montreal";
        int phoneNumber = 5551234;
        int income = 60000;

        Principal principal = new Principal(name, address, phoneNumber, income);

        Assert.Equal(name, principal.Name);
        Assert.Equal(address, principal.Address);
        Assert.Equal(phoneNumber, principal.PhoneNumber);
        Assert.Equal(income, principal.Income);
        Assert.Equal(0, principal.Balance);
    }
        
        [Fact]
        public void Constructor_WithDefaultIncome_()
        {

            string name = "Manel";
            string address = "Laval";
            int phoneNumber = 9999999;
            int defaultIncome = 50000;

            Principal principal = new Principal(name, address, phoneNumber);

            Assert.Equal(defaultIncome, principal.Income);
            Assert.Equal(0, principal.Balance);
        }
}