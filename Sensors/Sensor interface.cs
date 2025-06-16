using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor_Game
{

    public enum sensors
    {
        Audio

    }
    public interface ISensor
    {
        sensors Kind { get;set;}
        int NumOfActivate { get; set; }
       void activation();
    }
}
