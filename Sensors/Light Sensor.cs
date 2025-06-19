using System;

namespace Sensor_Game
{
    internal class LightSensor : ISensor
    {
        public sensorsType Kind { get; set; } = sensorsType.Light;
        public bool Activate { get; set; } =true;
        
        public void activation() { }
        public void RevealsSensor(IranAgentBase agent) { }
        public void RevealsAgentInfo(IranAgentBase agent)
        {

            Console.WriteLine($"the agent rank is {agent.Rank}");
            Console.WriteLine($"the agent num of sensors to exposed is {agent.NumSensorToExposed}");

        }

    }
    }
   


