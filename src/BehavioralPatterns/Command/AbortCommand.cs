namespace BehavioralPatterns.Command
{
    public class AbortCommand : IMachineCommand
    {
        private readonly Machine machine;

        public AbortCommand(Machine machine)
        {
            this.machine = machine;
        }
        public void Execute()
        {
            this.machine.Abort();
        }
    }
}
