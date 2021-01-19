namespace BehavioralPatterns.Command
{
    public class ResetCommand : IMachineCommand
    {
        private readonly Machine machine;

        public ResetCommand(Machine machine)
        {
            this.machine = machine;
        }
        public void Execute()
        {
            this.machine.Reset();
        }
    }
}
