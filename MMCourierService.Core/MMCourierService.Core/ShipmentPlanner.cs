  using MMCourierService;
using System.Collections.Generic;
using System.Linq;

public class ShipmentPlanner : IShipmentPlanner
{
    public Shipment CreateBestShipment(List<Package> remaining, double maxWeight)
    {
        var all = GetAllValidCombinations(remaining, maxWeight);

        return all
            .OrderByDescending(s => s.Packages.Count)
            .ThenByDescending(s => s.TotalWeight)
            .ThenBy(s => s.MaxDistance)
            .First();
    }

    private List<Shipment> GetAllValidCombinations(List<Package> packages, double maxWeight)
    {
        var result = new List<Shipment>();
        int n = packages.Count;

        for (int mask = 1; mask < (1 << n); mask++)
        {
            var combo = new List<Package>();
            double weight = 0;

            for (int i = 0; i < n; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    combo.Add(packages[i]);
                    weight += packages[i].Weight;
                }
            }

            if (weight <= maxWeight)
                result.Add(new Shipment(combo));
        }

        return result;
    }
}
