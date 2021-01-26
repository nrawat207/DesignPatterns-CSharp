namespace StructuralPatterns.Decorator
{
    public abstract class OtherNotifierBase : INotifier
    {
        public INotifier notifier;

        public OtherNotifierBase(INotifier notifier)
        {
            this.notifier = notifier;     
        }

        public virtual bool Send()
        {            
            return this.notifier.Send();
        }
    }
}
