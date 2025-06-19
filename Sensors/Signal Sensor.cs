using System;


namespace Sensor_Game
{
    internal class SignalSensor : ISensor
    {
        public sensorsType Kind { get; set; } = sensorsType.Signal;
        public bool Activate { get; set; } = true;

   
        public void RevealsSensor(IranAgentBase agent) { }
        public void activation() { }
        public void RevealsAgentInfo(IranAgentBase agent)
        {

            Console.WriteLine($"the agent rank is{agent.Rank}");

        }
    }

}


