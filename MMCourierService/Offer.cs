using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMCourierService
{
    public class Offer
    {
        public string Code { get; }
        public double DiscountPercent { get; }
        public double MinDistance { get; }
        public double MaxDistance { get; }
        public double MinWeight { get; }
        public double MaxWeight { get; }

        public Offer(string code, double discountPercent,
                     double minDistance, double maxDistance,
                     double minWeight, double maxWeight)
        {
            Code = code;
            DiscountPercent = discountPercent;
            MinDistance = minDistance;
            MaxDistance = maxDistance;
            MinWeight = minWeight;
            MaxWeight = maxWeight;
        }
    }

}
