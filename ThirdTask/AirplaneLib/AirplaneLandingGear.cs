using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneLib
{
    public class AirplaneLandingGear
    {
        public AirplaneLandingGear(int heightCM, int weightKG)
        {
            HeightCM = heightCM;
            WeightKG = weightKG;
        }
        public int HeightCM { get; private set; }
        public int WeightKG { get; private set; }
    }
}
