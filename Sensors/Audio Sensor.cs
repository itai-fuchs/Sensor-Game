using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor_Game
{
    internal class Audio_Sensor : ISensor
    {
        public sensors Kind { get; set; } = sensors.Audio;
        public int NumOfActivate { get; set; } = 0;

        public void activation()
        {
            NumOfActivate++;
        }

    }


}
