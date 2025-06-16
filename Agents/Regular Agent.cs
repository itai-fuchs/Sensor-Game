using Sensor_Game;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sensor_Game
{
    /// <summary>
    /// Represents a regular agent with sensors and vulnerability logic.
    /// </summary>
    internal class RegularAgent : IIranAgent
    {
        
        public RankType Rank { get; set; } = RankType.Regular;

       
        public int NumSensorToExposed { get; set; } = 2;

        
        public List<ISensor> FollowingSensors { get; set; } = new List<ISensor>();

        
        public List<ISensor> WeaknessSensorList { get; set; } = new List<ISensor>();

        /// <summary>
        /// Populates the WeaknessSensorList with random sensors.
        /// </summary>
        public void CreateWeaknessSensorList()
        {
            for (int i = 0; i < NumSensorToExposed; i++)
            {
                WeaknessSensorList.Add(SensorFactory.GetRandSensor());
            }
        }

        /// <summary>
        /// Counts how many followed sensors are in the agent's weaknesses.
        /// </summary>
        /// <returns>Number of relevant sensors.</returns>
        public int RelevantFollowingSensor()
        {
            int count = 0;
            foreach (ISensor sensor in FollowingSensors)
            {
                if (WeaknessSensorList.Any(w => w.Kind == sensor.Kind))
                {
                    count++;
                }
            }
            return count;
        }


        /// <summary>
        /// Determines if the agent is exposed based on the number of relevant sensors.
        /// </summary>
        /// <returns>True if exposed, otherwise false.</returns>
        public bool IsExposed()
        {
            return RelevantFollowingSensor() >= NumSensorToExposed;
        }

        /// <summary>
        /// Constructor initializes the weakness sensor list on creation.
        /// </summary>
        
       public void PrintExposedStatus ()
        {
            Console.WriteLine ($"{RelevantFollowingSensor()}/{NumSensorToExposed}");

        }
        public RegularAgent()
        {
            CreateWeaknessSensorList();
        }
    }
}
