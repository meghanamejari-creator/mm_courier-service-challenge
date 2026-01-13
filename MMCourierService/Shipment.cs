using System.Collections.Generic;
using MMCourierService;
using System.Linq;

public class Shipment
{
    public IReadOnlyList<Package> Packages { get; }
    public double TotalWeight => Packages.Sum(p => p.Weight);
    public double MaxDistance => Packages.Max(p => p.Distance);

    public Shipment(IEnumerable<Package> packages)
    {
        Packages = packages.ToList();
    }
}
