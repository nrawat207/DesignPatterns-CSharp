using System;

namespace BehavioralPatterns.Strategy
{
    public class ThermalLabelPrint : ILabelPrint
    {
        public void Print(Label label)
        {
            label.SetMaterial(Material.Synthetic);
        }
    }
}
