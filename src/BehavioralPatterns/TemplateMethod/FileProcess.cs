namespace BehavioralPatterns.TemplateMethod
{
    public abstract class FileProcess
    {
        public abstract IFile Read();

        public abstract bool Validate();

        public void ProcessFile()
        {
            Read();
            Validate();
            Upload();
            Archive();
        }

        internal void Upload()
        {
            //Upload file to file server
        }

        internal void Archive()
        {
            //Arhive file after upload
        }

    }
}
