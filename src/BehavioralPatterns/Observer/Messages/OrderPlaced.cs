namespace BehavioralPatterns.Observer.Messages
{
    public class OrderPlaced
    {
        public OrderPlaced(int orderId, string description)
        {
            this.OrderId = orderId;
            this.Description = description;
        }
        public int OrderId { get; set; }
        public string Description { get; set; }
    }
}
