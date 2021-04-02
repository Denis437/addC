using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneLib
{
    public class AirplaneWing
    {
        public AirplaneWing(string material, int weightKG)
        {
            Material = material;
            WeightKG = weightKG;
        }
        public string Material;
        public int WeightKG { get; set; }
    }
}
