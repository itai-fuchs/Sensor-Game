using Sensor_Game.Agents;
using System;
using System.Collections.Generic;


namespace Sensor_Game
{
    internal static class AgentFactory
    {
        private static readonly Random rnd = new Random();
        static List<IranAgentBase> agentList = new List<IranAgentBase>()

            {
                new FootSoldier(),
                new OrganizationLeader(),
                new SeniorCommander(),
                new SquadLeader(),
                new SeniorCommander()

            };

        public static List<sensorsType> CopySensorsWeakness;
        public static void PrintExposedStatus(IranAgentBase agent)
        {
           
            Console.WriteLine($"{agent.NumRelevantFolowingSensors}/{agent.NumSensorToExposed}");
        }
        public static bool CheckMatch(IranAgentBase agent, ISensor sensor)
        {
            return CopySensorsWeakness.Contains(sensor.Kind);
        }


        public static void AddFolowingSensor(ISensor sensor,IranAgentBase agent)
        {
            
            if (sensor.Activate && CheckMatch(agent, sensor))
            {
                agent.FollowingSensors.Add(sensor);
                CopySensorsWeakness.Remove(sensor.Kind);
                agent.NumRelevantFolowingSensors++;
                Console.WriteLine("sensor add sucssefuly");

            }
            else Console.WriteLine("sensor not add");
            PrintExposedStatus(agent);

        }
        public static void RemoveRandFollowingSensor(IranAgentBase agent)
        {
            if (agent.FollowingSensors.Count == 0)
                return;

            int index = rnd.Next(agent.FollowingSensors.Count);
            agent.FollowingSensors.RemoveAt(index);
            agent.NumRelevantFolowingSensors--;
            
        }


        public static void CreateWeaknessSensorList(IranAgentBase agent)
        {
            for (int i = 0; i < agent.NumSensorToExposed; i++)
            {
                agent.WeaknessSensorList.Add(SensorFactory.GetRandSensor().Kind);
            }
            CopySensorsWeakness = new List<sensorsType>(agent.WeaknessSensorList);

        }

        public static List<IranAgentBase> GetAllAgents()
        {


            return agentList;
        }

        public static IranAgentBase GetRandAgent()
        {

            int index = rnd.Next(0, agentList.Count);
            return agentList[index];


        }

    }


}



