using MMCourierService;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class DeliveryScheduler : IDeliveryScheduler
{
    private readonly IShipmentPlanner _planner = new ShipmentPlanner();

    public Dictionary<string, double> CalculateDeliveryTimes(List<Package> packages, int vehicleCount, double speed, double maxWeight)
    {
        var vehicles = Enumerable.Range(1, vehicleCount)
            .Select(i => new Vehicle(i, speed, maxWeight))
            .ToList();

        var remaining = new List<Package>(packages);
        var result = new Dictionary<string, double>();

        while (remaining.Any())
        {
            var vehicle = vehicles.OrderBy(v => v.AvailableAt).First();

            var shipment = _planner.CreateBestShipment(remaining, maxWeight);

            double travelTime = shipment.MaxDistance / speed;
            double deliveryTime = vehicle.AvailableAt + travelTime;

            foreach (var pkg in shipment.Packages)
                result[pkg.Id] = deliveryTime;

            vehicle.Assign(travelTime);

            foreach (var pkg in shipment.Packages)
                remaining.Remove(pkg);
        }

        return result;
    }
}
