namespace BehavioralPatterns.Strategy
{
    public class DefaultLabelPrint : ILabelPrint
    {
        public void Print(Label label)
        {
            label.SetMaterial(Material.Paper);
        }
    }
}
