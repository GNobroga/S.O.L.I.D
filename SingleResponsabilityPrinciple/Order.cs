namespace SingleResponsabilityPrinciple
{
    public class Order
    {
        public DateTime Date { get; private set; }

        public int Quantity { get; private set; }

        public void RemoveOrder(Order order)
        {
            // Logic
        }

        public void SendEmail()
        {
            // Logic
            // Esse método fere o princío SRP, o ideial é criar uma classe específica para isso.
        }

        public void IncludeOrder(Order order)
        {
            // logic
        }
        
    }
}