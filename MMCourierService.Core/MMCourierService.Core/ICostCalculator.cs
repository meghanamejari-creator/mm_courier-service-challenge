using MMCourierService;
//using System.IO.Packaging;

public interface ICostCalculator
{
    double Calculate(Package package, double baseCost);
}
