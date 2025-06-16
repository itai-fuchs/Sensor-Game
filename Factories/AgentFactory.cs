using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor_Game
{
    internal static class AgentsFctory
    {
        private static readonly Random rnd = new Random();
        static List<IIranAgent> agentList = new List<IIranAgent>()
            {
                new RegularAgent(),
            };
        public static List<IIranAgent> GetAllAgents()
        {


            return agentList;
        }

        public static IIranAgent GetRandAgent()
        {

            int index = rnd.Next(0, agentList.Count);
            return agentList[index];


        }


    }
}



