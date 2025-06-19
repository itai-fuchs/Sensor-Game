using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor_Game
{

    public enum sensorsType
    {
        Audio,
        Magnetic,
        Motion,
        Pulse,
        Thermal,
        Signal,
        Light,

    }
    public interface ISensor
    {
        sensorsType Kind { get; set; }
        bool Activate { get; set; }
        void RevealsAgentInfo(IranAgentBase agent);
        void RevealsSensor(IranAgentBase agent);
        void activation();
    }
}
