namespace BehavioralPatterns.Command
{
    public class RunCommand : IMachineCommand
    {
        private readonly Machine machine;

        public RunCommand(Machine machine)
        {
            this.machine = machine;
        }
        public void Execute()
        {
            this.machine.Run();
        }
    }
}
