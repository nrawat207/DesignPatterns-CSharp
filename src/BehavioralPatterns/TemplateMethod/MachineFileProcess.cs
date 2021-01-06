namespace BehavioralPatterns.TemplateMethod
{
    public class MachineFileProcess : FileProcess
    {
        private readonly IFile machineFile;

        public MachineFileProcess(IFile machineFile)
        {
            this.machineFile = machineFile;
        }
        
        public override IFile Read()
        {
            //Read Machine File
            if (this.machineFile == null)
                return null;
            else
                return machineFile;
        }

        public override bool Validate()
        {
            //Validate Machine file
            return true;
        }
    }
}
