using MMCourierService;
using System.Collections.Generic;

public interface IDeliveryScheduler
{
    Dictionary<string, double> CalculateDeliveryTimes(List<Package> packages, int vehicleCount, double speed, double maxWeight);
}
