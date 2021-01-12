using BehavioralPatterns.Observer.Messages;
using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Observer
{
    public class SalesService : IObservable<OrderPlaced>
    {
        private List<IObserver<OrderPlaced>> observers;

        public SalesService()
        {
            observers = new List<IObserver<OrderPlaced>>();   
        }

        public IDisposable Subscribe(IObserver<OrderPlaced> observer)
        {
            //add the observer(subscriber) if not registered.
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber<OrderPlaced>(observers, observer);
        }

        public void PlaceOrder(OrderPlaced order)
        {            
            //Order placed successfully!

            foreach (var observer in observers)
            {
                observer.OnNext(order);
            }
        }



        
    }
}
