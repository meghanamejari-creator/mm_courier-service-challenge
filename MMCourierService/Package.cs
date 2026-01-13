namespace MMCourierService
{
    public class Package
    {
        public string Id { get; }
        public double Weight { get; }
        public double Distance { get; }
        public string OfferCode { get; }

        public Package(string id, double weight, double distance, string offerCode)
        {
            Id = id;
            Weight = weight;
            Distance = distance;
            OfferCode = offerCode;
        }
    }
}
