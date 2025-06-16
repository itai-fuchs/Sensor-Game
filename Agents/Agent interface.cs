using System.Collections.Generic;
using Sensor_Game;
using System.Linq;

namespace Sensor_Game
{
    /// <summary>
    /// Defines different ranks/types of agents.
    /// </summary>
    public enum RankType
    {
        Regular
    }

    /// <summary>
    /// Interface defining the contract for Iran agents.
    /// </summary>
    public interface IIranAgent
    {
        /// <summary>
        /// The rank/type of the agent.
        /// </summary>
        RankType Rank { get; set; }

        /// <summary>
        /// Number of sensors required to expose the agent.
        /// </summary>
        int NumSensorToExposed { get; set; }

        /// <summary>
        /// List of sensors the agent is currently following.
        /// </summary>
        List<ISensor> FollowingSensors { get; set; }

        /// <summary>
        /// List of sensors that represent the agent's weaknesses.
        /// </summary>
        List<ISensor> WeaknessSensorList { get; set; }

        /// <summary>
        /// Counts how many followed sensors are relevant to the agent's weaknesses.
        /// </summary>
        int RelevantFollowingSensor();

        /// <summary>
        /// Initializes the agent's weakness sensor list.
        /// </summary>
        void CreateWeaknessSensorList();

        /// <summary>
        /// Checks if the agent is exposed based on followed sensors and weaknesses.
        /// </summary>
        bool IsExposed();
        void PrintExposedStatus();
    }
}
