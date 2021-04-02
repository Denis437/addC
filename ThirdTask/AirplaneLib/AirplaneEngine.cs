using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneLib
{
    public class AirplaneEngine
    {
        public AirplaneEngine(int hp, int weightKG)
        {
            HP = hp;
            WeightKG = weightKG;
        }
        public int HP { get; private set; }
        public int WeightKG { get; private set; }
    }
}
