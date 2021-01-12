using BehavioralPatterns.Observer.Messages;
using System;

namespace BehavioralPatterns.Observer
{
    public class BillingService : IObserver<OrderPlaced>
    {
        public int OrderId { get; set; }
        public void OnCompleted()
        {
            //
        }

        public void OnError(Exception error)
        {
            //
        }

        public void OnNext(OrderPlaced order)
        {
            //Generate Bill for order
            this.OrderId = order.OrderId;
            Console.WriteLine("Bill generated for Order : {0}", order.OrderId);
        }
    }
}
