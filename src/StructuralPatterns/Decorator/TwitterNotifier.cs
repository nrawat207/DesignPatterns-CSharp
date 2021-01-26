using System;

namespace StructuralPatterns.Decorator
{
    public class TwitterNotifier: OtherNotifierBase
    {
        public TwitterNotifier(INotifier notifier):base(notifier){ }

        public override bool Send()
        {      
            Console.WriteLine("Send Twitter message");
            if (base.Send()) return true;
            else return false;
        }
    }
}
