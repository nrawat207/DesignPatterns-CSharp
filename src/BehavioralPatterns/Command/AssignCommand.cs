using System;

namespace BehavioralPatterns.Command
{
    public class AssignCommand : IMachineCommand
    {
        private readonly Machine machine;

        public AssignCommand(Machine machine)
        {
            this.machine = machine;
        }
        public void Execute()
        {
            this.machine.Assgin();
        }
    }
}
