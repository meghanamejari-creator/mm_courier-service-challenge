using MMCourierService;
using System;
using System.Collections.Generic;
//using System.IO.Packaging;
using System.Linq;

public class OfferService : IOfferService
{
    private readonly List<Offer> _offers = new()
    {
        new Offer("OFR001", 10, 70, 200, 0, 200),
        new Offer("OFR002", 7, 100, 250, 10, 150),
        new Offer("OFR003", 5, 50, 150, 50, 250)
    };

    public double GetDiscount(Package package, double deliveryCost)
    {
        var offer = _offers.FirstOrDefault(o => o.Code == package.OfferCode);
        if (offer == null)
            return 0;

        if (package.Distance < offer.MinDistance || package.Distance > offer.MaxDistance)
            return 0;

        if (package.Weight < offer.MinWeight || package.Weight > offer.MaxWeight)
            return 0;

        return deliveryCost * offer.DiscountPercent / 100;
    }
}