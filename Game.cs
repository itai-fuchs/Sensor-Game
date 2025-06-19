using System;
using System.Collections.Generic;
using System.Linq;


namespace Sensor_Game
{
    internal class Game
    {
        List<ISensor> sensorList = SensorFactory.GetAllSensors();
        IranAgentBase agent = AgentFactory.GetRandAgent();


        public void Start()
        {
            AgentFactory.CreateWeaknessSensorList(agent);

            Console.WriteLine("---- Welcome to the interrogation room ----\n");
            Console.WriteLine("You are interrogating an Iranian spy.");
            Console.WriteLine($"In room number 7 is waiting for you an Iran agent.");

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
            int turnCounter = 0;
            int magneticCheck = 0;

            while (!agent.IsExposed())
            {
                Console.WriteLine("\nSelect a sensor to activate:");
                Console.WriteLine("0 - Audio Sensor");
                Console.WriteLine("1 - Motion Sensor");
                Console.WriteLine("2 - Pulse Sensor");
                Console.WriteLine("3 - Magnetic Sensor");
                Console.WriteLine("4 - Thermal Sensor");
                Console.WriteLine("5 - Signal Sensor");
                Console.WriteLine("6 - Light Sensor");
                Console.WriteLine("9 - Exit");

                int.TryParse(Console.ReadLine(), out int choise);




                switch (choise)
                {
                    case 0:
                        AgentFactory.AddFolowingSensor(sensorList[choise], agent);

                        break;
                    case 1:
                        AgentFactory.AddFolowingSensor(sensorList[choise], agent);
                        sensorList[choise].activation();
                        break;
                    case 2:
                        AgentFactory.AddFolowingSensor(sensorList[choise], agent);
                        sensorList[choise].activation();
                        break;
                    case 3:
                        AgentFactory.AddFolowingSensor(sensorList[choise], agent);
                        magneticCheck++;
                        break;

                    case 4:
                        AgentFactory.AddFolowingSensor(sensorList[choise], agent);
                        sensorList[choise].RevealsSensor(agent);
                        break;

                    case 5:
                        AgentFactory.AddFolowingSensor(sensorList[choise], agent);
                        sensorList[choise].RevealsAgentInfo(agent);
                        break;
                    case 6:
                        AgentFactory.AddFolowingSensor(sensorList[choise], agent);
                        sensorList[choise].RevealsAgentInfo(agent);
                        break;

                    case 9:
                        Console.WriteLine("Exiting interrogation...");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                turnCounter++;


                if (turnCounter % 3 == 0 && (!agent.FollowingSensors.Any(s => s.Kind == sensorsType.Magnetic) || magneticCheck <= 2))
                {
                    if (agent.FollowingSensors.Count >= 1)
                    {
                        AgentFactory.RemoveRandFollowingSensor(agent);
                        Console.WriteLine("⚠️ The agent managed to disable one of your sensors!");
                        AgentFactory.PrintExposedStatus(agent);
                    }
                }
                else if (agent.Rank == RankType.SeniorCommander)
                {
                    if (agent.FollowingSensors.Count >= 2)
                    {
                   
                        AgentFactory.RemoveRandFollowingSensor(agent);
                        AgentFactory.RemoveRandFollowingSensor(agent);
                        AgentFactory.PrintExposedStatus(agent);
                        Console.WriteLine("⚠️ The agent managed to disable two of your sensors!");
                    }
                }

            }
            Console.WriteLine("\n✅ Agent has been exposed successfully!");
        }

    }

}




