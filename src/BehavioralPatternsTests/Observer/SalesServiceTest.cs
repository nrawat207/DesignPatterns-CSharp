using BehavioralPatterns.Observer;
using BehavioralPatterns.Observer.Messages;
using NUnit.Framework;

namespace BehavioralPatternsTests.Observer
{
    [TestFixture]
    public class SalesServiceTest
    {
        private SalesService salesService;

        [SetUp]
        public void TestSetup()
        {
            salesService = new SalesService();            
        }

        [Test]
        public void PlaceOrder_ShouldNotifyObserver()
        {            
            var observer1 = new BillingService();
            var observer2 = new ShippingService();
            salesService.Subscribe(observer1);
            salesService.Subscribe(observer2);

            var order = new OrderPlaced(1, "Order1");
            salesService.PlaceOrder(order);

            Assert.AreEqual(1, observer1.OrderId);
            Assert.AreEqual(1, observer2.OrderId);


        }
    }
}
