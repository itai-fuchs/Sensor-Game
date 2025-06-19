using System;


namespace Sensor_Game
{
    internal class PulseSensor:ISensor
    {
        public sensorsType Kind { get; set; } = sensorsType.Pulse;
        public bool Activate { get; set; } = true;
        public int NumOfActivate { get; set; } = 0;
        public int MaxNumOfActivate { get; set; } = 3;
        public void RevealsAgentInfo(IranAgentBase agent) { }
        public void RevealsSensor(IranAgentBase agent) { }

        public void activation()
        {
            if (Activate)
            {
                NumOfActivate++;
            }
            else
            {
                Console.WriteLine("broken sensor");
                if (NumOfActivate >= MaxNumOfActivate)
                {
                    Activate = false;

                }

            }

        }

    }
}

