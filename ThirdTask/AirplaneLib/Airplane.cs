using System;

namespace AirplaneLib
{
    public class Airplane
    {
        public Airplane(AirplaneEngine engine, AirplaneLandingGear landingGear, AirplaneWing wing)
        {
            Engine = engine;
            LandingGear = landingGear;
            Wing = wing;
        }
        public AirplaneEngine Engine { get; private set; }
        public AirplaneLandingGear LandingGear { get; private set; }
        public AirplaneWing Wing { get; private set; }
        public string Destination { get; set; } = null;
        public void Fly()
        {

        }
    }
}
