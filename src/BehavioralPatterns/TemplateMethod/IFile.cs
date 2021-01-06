namespace BehavioralPatterns.TemplateMethod
{
    public interface IFile
    {
        void GetFilePath();
    }

    public class File:IFile
    {
        public File(string name)
        {
            this.FileName = name;
        }
        public string FileType { get; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileVersion { get; set; }
        public string IsValid { get; set; }

        public void GetFilePath()
        {
            throw new System.NotImplementedException();
        }
    }

}
