using System;
namespace Sensor_Game
{
    internal class ThermalSensor : ISensor
    {
        public sensorsType Kind { get; set; } = sensorsType.Thermal;
        public bool Activate { get; set; } = true;

        public void RevealsAgentInfo(IranAgentBase agent) { }
        public void activation() { }
        public void RevealsSensor(IranAgentBase agent) 
        {
            Random random = new Random();
            int index =random.Next(0, agent.FollowingSensors.Count - 1);
            Console.WriteLine($"the agent have weakness for {agent.FollowingSensors[index].Kind}");
        }



    }


}


