namespace OpenClosedPrinciple
{
    public sealed class DiscountClientAssociated : Order
    {
        public override double Discount(double finalValue)
        {
            return finalValue - 100;
        }
    }
}