using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class SmsNotifier : OtherNotifierBase
    {
        public SmsNotifier(INotifier notifier) :base(notifier){ }

        public override bool Send()
        {
            Console.WriteLine("Send SMS");
            if (base.Send()) return true;
            else return false;
        }
    }
}
