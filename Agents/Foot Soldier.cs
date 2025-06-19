
namespace Sensor_Game
{
    /// <summary>
    /// Represents a regular agent with sensors and vulnerability logic.
    /// </summary>
    internal class FootSoldier : IranAgentBase
    {


        public FootSoldier()
        {
            Rank = RankType.FootSoldier;
            NumSensorToExposed = 2;

        }
    }



}
