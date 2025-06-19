

namespace Sensor_Game.Agents
{
    internal class SquadLeader : IranAgentBase
    {

        public SquadLeader() {
            Rank = RankType.SquadLeader;
            NumSensorToExposed = 4;
        }

    }
}