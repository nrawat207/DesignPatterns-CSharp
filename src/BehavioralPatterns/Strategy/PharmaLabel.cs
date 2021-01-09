namespace BehavioralPatterns.Strategy
{
    public class PharmaLabel : ILabelPrint
    {
        public void Print(Label label)
        {
            label.SetMaterial(Material.Paper);
        }
    }
}
