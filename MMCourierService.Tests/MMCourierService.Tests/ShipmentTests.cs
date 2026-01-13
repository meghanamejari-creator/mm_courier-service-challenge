using MMCourierService;
using Xunit;

public class ShipmentTests
{
    [Fact]
    public void Shipment_should_choose_more_packages_over_single_heavier()
    {
        var pkgs = new List<Package>
    {
        new Package("P1", 50, 10, ""),
        new Package("P2", 50, 20, ""),
        new Package("P3", 100, 5, "")
    };

        var planner = new ShipmentPlanner();
        var shipment = planner.CreateBestShipment(pkgs, 100);

        Assert.Equal(2, shipment.Packages.Count); // P1 + P2 preferred over P3
    }

}
