using BehavioralPatterns.Command;
using NUnit.Framework;

namespace BehavioralPatternsTests.Command
{
    [TestFixture]
    public class MachineControllerTests
    {
        private MachineController machineController;

        [SetUp]
        public void TestSetup()
        {            
            machineController = new MachineController();
        }

        [Test]
        public void ShouldAssignJobToMachine()
        {
            
            var machine = new Machine(new Job());
            var assignCommand = new AssignCommand(machine);
            machineController.SetCommand(assignCommand);
            machineController.Command.Execute();
            Assert.AreEqual(machine.JobStatus, JobStatus.Assgined);
        }

        [Test]
        public void ShouldRunMachineJob()
        {

            var machine = new Machine(new Job());
            var runCommand = new RunCommand(machine);
            machineController.SetCommand(runCommand);
            machineController.Command.Execute();
            Assert.AreEqual(machine.JobStatus, JobStatus.Running);
        }

        [Test]
        public void ShouldAbortMachineJob()
        {

            var machine = new Machine(new Job());
            var abortCommand = new AbortCommand(machine);
            machineController.SetCommand(abortCommand);
            machineController.Command.Execute();
            Assert.AreEqual(machine.JobStatus, JobStatus.Aborted);
        }

        [Test]
        public void ShouldResetMachine()
        {

            var machine = new Machine(new Job());
            var resetCommand = new ResetCommand(machine);
            machineController.SetCommand(resetCommand);
            machineController.Command.Execute();
            Assert.AreEqual(machine.JobStatus, JobStatus.Ready);
        }
    }
}
