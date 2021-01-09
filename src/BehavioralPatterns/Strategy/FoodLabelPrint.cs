namespace BehavioralPatterns.Strategy
{
    public class FoodLabelPrint : ILabelPrint
    {
        public void Print(Label label)
        {
            label.SetMaterial(Material.Plastic);
            //print label
        }
    }
}
