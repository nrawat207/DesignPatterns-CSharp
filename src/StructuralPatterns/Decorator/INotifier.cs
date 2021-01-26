using System.Collections.Generic;

namespace StructuralPatterns.Decorator
{
    public interface INotifier
    {
        bool Send();
    }

    public enum Notification
    {
        Email,
        SMS,
        Facebook,
        Twitter
    }
}
