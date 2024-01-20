namespace OpenClosedPrinciple
{
    public class DiscountClientEspecial : Order
    {
        public override double Discount(double finalValue)
        {
            return finalValue - 200;
        }
    }
}