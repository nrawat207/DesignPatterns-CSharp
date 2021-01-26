using System;
using System.Collections.Generic;

namespace StructuralPatterns.Decorator
{
    public class EmailNotifier : INotifier
    {
        
        public bool Send()
        {
            Console.WriteLine("Send Email");
            return true;
            
        }
    }
}
