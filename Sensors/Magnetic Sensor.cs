
namespace Sensor_Game
{
    internal class MagneticSensor : ISensor
    {
        public sensorsType Kind { get; set; } = sensorsType.Magnetic;
        public bool Activate { get; set; } = true;  
        public int NumOfActivate { get; set; } = 0;
        public int MaxNumOfActivate { get; set; }
        public void RevealsAgentInfo(IranAgentBase agent) { }
        public void RevealsSensor(IranAgentBase agent) { }

        public void activation() { }
        
           
    }
}

