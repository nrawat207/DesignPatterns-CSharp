namespace BehavioralPatterns.Strategy
{
    public class Printer
    {
        private ILabelPrint labelPrint;

        public Printer() : this(new DefaultLabelPrint())
        {

        }

        public Printer(ILabelPrint labelPrint)
        {
            this.labelPrint = labelPrint;
        }

        public void Print(Label label)
        {
            this.labelPrint.Print(label);
        }
    }
}
