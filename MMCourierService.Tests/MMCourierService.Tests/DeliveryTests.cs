using MMCourierService;
using Xunit;

public class DeliveryTests
{
    [Fact]
    public void Scheduler_should_assign_earliest_available_vehicle()
    {
        var pkgs = new List<Package>
    {
        new Package("PKG1", 50, 100, ""),
        new Package("PKG2", 50, 10, "")
    };

        var scheduler = new DeliveryScheduler();

        var result = scheduler.CalculateDeliveryTimes(pkgs, 1, 50, 100);

        Assert.True(result["PKG2"] > result["PKG1"]); // second package delivered later
    }


}
