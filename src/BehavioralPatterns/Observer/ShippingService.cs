using BehavioralPatterns.Observer.Messages;
using System;

namespace BehavioralPatterns.Observer
{
    public class ShippingService : IObserver<OrderPlaced>
    {
        public int OrderId { get; set; }

        public void OnCompleted()
        {
            //No Implementation
        }

        public void OnError(Exception error)
        {
            //No Implementation
        }

        public void OnNext(OrderPlaced value)
        {
            this.OrderId = value.OrderId;
            //Ship the order
            Console.WriteLine("Order {0} shipped successfully!", value.OrderId);
        }
    }
}
