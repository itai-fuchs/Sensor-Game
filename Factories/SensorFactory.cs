
using System;
using System.Collections.Generic;


namespace Sensor_Game
{
    internal class SensorFactory
    {
        private static readonly Random rnd = new Random();
        static List<ISensor> sensorList = new List<ISensor>()
            {
                new AudioSensor(),
                new MotionSensor(),
                new PulseSensor(),
                new MagneticSensor(),
                new ThermalSensor(),
                 new SignalSensor(),
                new LightSensor(),
            };
        public static List<ISensor> GetAllSensors()
        {

            return sensorList;
        }

        public static ISensor GetRandSensor()
        {
            
            int index = rnd.Next(0, sensorList.Count);
            return sensorList[index];


        }
    }

}
