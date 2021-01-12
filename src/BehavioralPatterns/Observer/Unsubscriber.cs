using BehavioralPatterns.Observer.Messages;
using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Observer
{
    internal class Unsubscriber<T> : IDisposable
    {
        private List<IObserver<OrderPlaced>> observers;
        private IObserver<OrderPlaced> observer;

        public Unsubscriber(List<IObserver<OrderPlaced>> observers, IObserver<OrderPlaced> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}