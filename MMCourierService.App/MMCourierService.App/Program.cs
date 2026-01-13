// using MMCourierService.Core;
using MMCourierService;
using System.Globalization;

var input = Console.ReadLine()!.Split();
double baseCost = double.Parse(input[0]);
int packageCount = int.Parse(input[1]);

var packages = new List<Package>();

for (int i = 0; i < packageCount; i++)
{
    var parts = Console.ReadLine()!.Split();
    packages.Add(new Package(
        parts[0],
        double.Parse(parts[1]),
        double.Parse(parts[2]),
        parts[3]
    ));
}

var vehicleInput = Console.ReadLine()!.Split();
int vehicleCount = int.Parse(vehicleInput[0]);
double speed = double.Parse(vehicleInput[1]);
double maxWeight = double.Parse(vehicleInput[2]);

var costCalculator = new CostCalculator();
var offerService = new OfferService();
var scheduler = new DeliveryScheduler();

var deliveryTimes = scheduler.CalculateDeliveryTimes(packages, vehicleCount, speed, maxWeight);

foreach (var pkg in packages)
{
    var cost = costCalculator.Calculate(pkg, baseCost);
    var discount = offerService.GetDiscount(pkg, cost);
    var total = cost - discount;
    var time = deliveryTimes[pkg.Id];

    Console.WriteLine($"{pkg.Id} {discount:F0} {total:F0} {time:F2}");
}
