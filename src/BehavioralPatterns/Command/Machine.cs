namespace BehavioralPatterns.Command
{
    public class Machine
    {
        public Machine(Job job)
        {
            this.AssginedJob = job;
        }
        public Job AssginedJob { get; set; }

        public string MachineNo { get; set; }

        public JobStatus JobStatus { get; set; }

        public void Assgin(){
            this.JobStatus  = JobStatus.Assgined;
        }

        public void Run()
        {
            this.JobStatus = JobStatus.Running;
        }

        public void Abort()
        {
            this.JobStatus = JobStatus.Aborted;
        }

        public void Reset()
        {
            this.JobStatus = JobStatus.Ready;
        }



    }

    public enum MachineActions
    {
        Assign,        
        Reset,
        Abort,
        Run
    }
    public enum JobStatus
    {
          Assgined
        , Ready
        , Running
        , Aborted
        , Error

    }

    public class Job
    {

        public int JobId { get; set; }
        public string Description { get; set; }
    }
}
