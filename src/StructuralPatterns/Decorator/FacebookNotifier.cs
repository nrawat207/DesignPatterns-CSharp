using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class FacebookNotifier : OtherNotifierBase
    {
        public FacebookNotifier(INotifier notifier) : base(notifier){ }

        public override bool Send()
        {           
            Console.WriteLine("Send Facebook message");
            if (base.Send()) return true;
            else return false;
           
        }
    }
}
