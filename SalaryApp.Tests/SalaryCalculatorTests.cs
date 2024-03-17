using Lab01.SalaryApp;
namespace Lab01.SalaryApp.Tests;

public class SalaryCalculatorTests
{
    [Fact]
    public void ProcessSalarySlip_WithValidInput_ShouldReturnSalarySlip()
    {
        // Arrange
            var grossSalary = 5000m;
            var expected = 5000m - ((5000m * .20m) + (5000m * .07m) + 200m);
        // Act

            var result = SalaryCalculator.ProcessSalarySlip(grossSalary);
        
        // Assert

        Assert.NotNull(result);
        Assert.Equal(expected, result.NetSalary);
        Assert.Equal(5000m * 0.2m, result.FederalTax);
        Assert.Equal(5000m * 0.07m, result.SocialSecurity);
        Assert.Equal(200m, result.HealthInsurance);
        Assert.Equal(5000m, result.GrossSalary);
        Assert.Equal((5000m * .20m) + (5000m * .07m) + 200m, result.TotalDeductions);
    }
}