
using BehavioralPatterns.TemplateMethod;
using NUnit.Framework;

namespace BehavioralPatternsTests.TemplateMethod
{
    [TestFixture]
    public class MachineFileProcessTest
    {
        private IFile machineFile;
        private FileProcess machineFileProcess;

        [SetUp]
        public void TestSetup()
        {
            machineFile = new File("File1");
            
            machineFileProcess = new MachineFileProcess(machineFile);
        }

        [Test]
        public void Validate_Success()
        {
            Assert.IsTrue(machineFileProcess.Validate());
        }

        [Test]
        public void Read_Success()
        {
            var file = machineFileProcess.Read();
            Assert.AreEqual(file, machineFile);
        }
    }
}
