using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    public enum Material
    {
        Paper,
        Plastic,
        Cotton,
        Synthetic,
        IndutrialVinyl,
        SemilGloss

    }    

    public class Label
    {
        public string Prefix { get; set; }
        public Material LabelMaterial { get; set; }
        public string Content { get; set; }

        public void SetMaterial(Material material)
        {
            this.LabelMaterial = material;
        }
    }
}
