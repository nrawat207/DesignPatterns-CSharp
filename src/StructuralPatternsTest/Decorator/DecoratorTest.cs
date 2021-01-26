using NUnit.Framework;
using StructuralPatterns.Decorator;
using System.Collections.Generic;

namespace StructuralPatternsTest.Decorator
{
    [TestFixture]
    public class DecoratorTest
    {
        private INotifier notifier;
        

        [Test]
        public void ShouldNotifyByEmailAndSMS()
        {
            List<Notification> notifications = new List<Notification>();

            notifier = new EmailNotifier();
            notifier = new SmsNotifier(notifier);

            Assert.IsTrue(notifier.Send());
        }
    }
}
