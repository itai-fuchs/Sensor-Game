using System.Collections.Generic;


namespace Sensor_Game
{
    /// <summary>
    /// Defines different ranks/types of agents.
    /// </summary>
    public enum RankType
    {
        FootSoldier,
        SquadLeader,
        SeniorCommander,
        OrganizationLeader,
    }

    /// <summary>
    /// Interface defining the contract for Iran agents.
    /// </summary>
    public abstract class IranAgentBase
    {
        /// <summary>
        /// The rank/type of the agent.
        /// </summary>
        public RankType Rank { get; protected set; }

        /// <summary>
        /// Number of sensors required to expose the agent.
        /// </summary>
        public int NumSensorToExposed { get; protected set; }
        public int NumRelevantFolowingSensors { get;set; }

        /// <summary>
        /// List of sensors the agent is currently following.
        /// </summary>
        public List<ISensor> FollowingSensors { get; set; }

        /// <summary>
        /// List of sensors that represent the agent's weaknesses.
        /// </summary>
        public List<sensorsType> WeaknessSensorList { get; set; }

        

        public IranAgentBase()
        {
            FollowingSensors = new List<ISensor>();
            WeaknessSensorList = new List<sensorsType>();
            NumRelevantFolowingSensors = 0;
        }
        

        /// <summary>
        /// Checks if the agent is exposed based on followed sensors and weaknesses.
        /// </summary>
        public bool IsExposed()
        {
            return NumRelevantFolowingSensors >NumSensorToExposed;

        }




    }
}
