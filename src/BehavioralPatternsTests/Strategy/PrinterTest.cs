using BehavioralPatterns.Strategy;
using NUnit.Framework;

namespace BehavioralPatternsTests.Strategy
{
    [TestFixture]
    public class PrinterTest
    {
        private Label label;
        private Printer printer;

        [SetUp]
        public void TestSetup()
        {
            label = new Label();
            printer = new Printer();
        }

        [Test]
        public void Print_with_FoodPrintLabel()
        {
            this.printer = new Printer(new FoodLabelPrint());
            this.printer.Print(label);
            Assert.AreEqual(label.LabelMaterial, Material.Plastic);
        }

        [Test]
        public void Print_with_PharmaPrintLabel()
        {
            this.printer = new Printer(new PharmaLabel());
            this.printer.Print(label);
            Assert.AreEqual(label.LabelMaterial, Material.Paper);
        }


    }
}
