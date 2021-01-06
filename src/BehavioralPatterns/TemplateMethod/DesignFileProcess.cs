namespace BehavioralPatterns.TemplateMethod
{
    public class DesignFileProcess : FileProcess
    {
        private readonly IFile designFile;

        public DesignFileProcess(IFile designFile)
        {

            this.designFile = designFile;
        }

        public override IFile Read()
        {
            //Read Design File
            return designFile;
        }

        public override bool Validate()
        {
            //Validate Design file
            return true;
        }
    }
}
