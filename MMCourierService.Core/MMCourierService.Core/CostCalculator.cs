using MMCourierService;
//using System.IO.Packaging;

public class CostCalculator : ICostCalculator
{
    public double Calculate(Package package, double baseCost)
    {
        return baseCost + (package.Weight * 10) + (package.Distance * 5);
    }
}
