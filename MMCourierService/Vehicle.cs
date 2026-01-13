public class Vehicle
{
    public int Id { get; }
    public double Speed { get; }
    public double MaxWeight { get; }
    public double AvailableAt { get; private set; }

    public Vehicle(int id, double speed, double maxWeight)
    {
        Id = id;
        Speed = speed;
        MaxWeight = maxWeight;
        AvailableAt = 0;
    }

    public void Assign(double travelTime)
    {
        AvailableAt += 2 * travelTime; // go and return
    }
}
