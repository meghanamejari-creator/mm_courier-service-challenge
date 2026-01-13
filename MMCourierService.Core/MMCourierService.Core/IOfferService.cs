using MMCourierService;
//using System.IO.Packaging;

public interface IOfferService
{
    double GetDiscount(Package package, double deliveryCost);
}

