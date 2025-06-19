

namespace Sensor_Game
{
    internal class AudioSensor : ISensor
    {
        public sensorsType Kind { get; set; } = sensorsType.Audio;
        public bool Activate { get; set; }=true;
       public void RevealsAgentInfo(IranAgentBase agent) { }
        public void RevealsSensor(IranAgentBase agent) { }
        public void activation() { }

    }
}


