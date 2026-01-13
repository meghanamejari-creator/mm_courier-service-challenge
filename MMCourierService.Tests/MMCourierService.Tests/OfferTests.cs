using MMCourierService;
using Xunit;

public class OfferTests
{
    [Fact]
    public void OFR003_should_give_5_percent_when_conditions_match()
    {
        var pkg = new Package("PKG3", 10, 100, "OFR003");
        double deliveryCost = 700;

        var offerService = new OfferService();

        var discount = offerService.GetDiscount(pkg, deliveryCost);

        Assert.Equal(35, discount);
    }


    [Fact]
    public void Invalid_offer_code_should_give_zero_discount()
    {
        var pkg = new Package("PKG1", 10, 100, "INVALID");
        var service = new OfferService();

        var discount = service.GetDiscount(pkg, 700);

        Assert.Equal(0, discount);
    }


    [Fact]
    public void Offer_should_not_apply_when_weight_not_in_range()
    {
        var pkg = new Package("PKG1", 5, 100, "OFR003"); // OFR003 min weight is 50
        var service = new OfferService();

        var discount = service.GetDiscount(pkg, 700);

        Assert.Equal(0, discount);
    }

}
