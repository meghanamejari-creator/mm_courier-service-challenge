using MMCourierService;
using System.Collections.Generic;

public interface IShipmentPlanner
{
    Shipment CreateBestShipment(List<Package> remainingPackages, double maxWeight);
}
