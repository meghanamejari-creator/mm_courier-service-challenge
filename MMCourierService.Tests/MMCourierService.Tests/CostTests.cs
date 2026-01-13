using MMCourierService;
using Xunit;

public class CostTests
{
    [Fact]
    public void Should_calculate_delivery_cost_correctly()
    {
        var pkg = new Package("PKG1", 10, 100, "OFR003");
        double baseCost = 100;

        var calculator = new CostCalculator();

        var cost = calculator.Calculate(pkg, baseCost);

        Assert.Equal(700, cost);
    }

    [Fact]
    public void Cost_should_be_base_plus_weight_when_distance_is_zero()
    {
        var pkg = new Package("PKG1", 10, 0, "NA");
        var calc = new CostCalculator();

        var cost = calc.Calculate(pkg, 100);

        Assert.Equal(200, cost); // 100 + (10*10)
    }

}
