using _07.MilitaryElite2.Contracts_Interfaces;
using _07.MilitaryElite2.Enums;
using _07.MilitaryElite2.Models_Classes;
using System;
using System.Collections.Generic;

namespace _07.MilitaryElite2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,ISoldier> soldiersByIdList = new Dictionary<string, ISoldier>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                //public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
                //Private 1 Peter Johnson 22.22
                //Private 222 Tony Samthon 80.08
                if (input[0] == "End")
                {
                    break;
                }
                string id = input[1];
                string firstName = input[2];
                string lastName = input[3];


                if (input[0] == "Private")
                {
                    decimal salary = decimal.Parse(input[4]);
                    Private @private = new Private(id, firstName, lastName, salary);
                    soldiersByIdList.Add(@private.Id,@private);
                }
                else if (input[0] == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(input[4]);
                    Private @private = new Private(id, firstName, lastName, salary);
                    ILieutenantGeneral lieutenantGen = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < input.Length; i++)
                    {
                        string soldierId = input[i];
                        if (!soldiersByIdList.ContainsKey(soldierId))
                        {
                            continue;
                        }
                        lieutenantGen.AddPrivate((IPrivate)soldiersByIdList[soldierId]);
                    }
                    soldiersByIdList[id] = lieutenantGen;
                }
                else if (input[0] == "Commando")
                {
                    decimal salary = decimal.Parse(input[4]);
                    bool isCorpsValid = Enum.TryParse(input[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    ICommando commando = new Commando(id, firstName, lastName, salary, corps);
                    for (int i = 6; i < input.Length; i += 2)
                    {
                        string missionName = input[i];
                        string status = input[i + 1];

                        bool isMissionStateValid = Enum.TryParse(status, out MissionState missionState);
                        if (!isMissionStateValid)
                        {
                            continue;
                        }
                        IMission mission = new Mission(missionName, missionState);
                        commando.AddMission(mission);

                    }

                    soldiersByIdList[id] = commando;
                }
                else if (input[0] == "Engineer")
                {
                    decimal salary = decimal.Parse(input[4]);
                    bool isCorpsValid = Enum.TryParse(input[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < input.Length; i += 2)
                    {
                        string part = input[i];
                        int hours = int.Parse(input[i + 1]);
                        IRepair repair = new Repair(part, hours);

                        engineer.AddRepairs(repair);
                    }
                    soldiersByIdList[id] = engineer;
                }
                else if (input[0] == "Spy")
                {
                    int codeNumber = int.Parse(input[4]) ;
                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiersByIdList[id]=spy;

                }
            }

            foreach (var soldier in soldiersByIdList.Values)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
