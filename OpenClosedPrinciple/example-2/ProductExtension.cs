namespace OpenClosedPrinciple
{
    public static class ProductExtension 
    {
        public static double Profit(this Product product)
        {
            try 
            {
                return Convert.ToDouble((product.Sell - product.Cost) / product.Sell * 100);
            }
            catch 
            {
                throw;
            }
        }
    }
}