using System.Collections.Generic;

namespace BehavioralPatterns.Command
{
    public class MachineController
    {
        private  List<IMachineCommand> commands;

        public MachineController()
        {
            this.commands = new List<IMachineCommand>();

        }

        public IMachineCommand Command { get; set; }
        public void SetCommand(IMachineCommand command)
        {
            this.Command = command;
            if (!this.commands.Contains(command))
                this.commands.Add(command);
        }

        public void RemoveCommand(IMachineCommand command)
        {
            if (this.Command == command)
                this.Command = null;

            if (this.commands.Contains(command))
                this.commands.Remove(command);
        }

        public void ExecuteAll()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
