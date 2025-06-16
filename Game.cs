
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor_Game
{
    internal class Game
    {
        List<ISensor> sensorList = SensorFactory.GetAllSensors();
        IIranAgent agent = AgentsFctory.GetRandAgent();
        public void Start()
        {
            Console.WriteLine("---- Welcome to the interrogation room ----\n");
            Console.WriteLine("You are interrogating an Iranian spy.");
            Console.WriteLine($"In room number 7 is waiting for you an Iran agent.\nHis rank is {agent.Rank}");

            while (true)
            {
                Console.WriteLine("\n1 - Start");
                Console.WriteLine("0 - Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Turn();
                        return; 
                    case "0":
                        Console.WriteLine("Goodbye.");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }



        public void Turn()
        {
            while (!agent.IsExposed())
            {
                Console.WriteLine("\nSelect a sensor to activate:");
                Console.WriteLine("1 - Audio Sensor");
                Console.WriteLine("0 - Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        agent.FollowingSensors.Add(new Audio_Sensor());
                        agent.PrintExposedStatus();
                        break;

                    case "0":
                        Console.WriteLine("Exiting interrogation...");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }

            Console.WriteLine("\n✅ Agent has been exposed successfully!");
        }

    }
}
