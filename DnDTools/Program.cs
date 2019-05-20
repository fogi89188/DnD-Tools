using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DnDTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> initiative = new Dictionary<string, int>();
            InitiativeTracker init = new InitiativeTracker(initiative);

            CharacterStatGeneratorClass cs = new CharacterStatGeneratorClass();
            string command = "";
            while (command != "end")
            {
                string[] commandArr = Console.ReadLine().Split().ToArray();
                switch (commandArr[0])
                {
                    case "stats":{
                            try
                            {
                                cs.GenerateAllNTimes(int.Parse(commandArr[1]));
                                Console.WriteLine(cs.ToString());
                            }
                            catch (Exception)
                            {
                                cs.GenerateAllNTimes(1);
                                Console.WriteLine(cs.ToString());
                            }
                            break;
                        }
                    case "init":{
                            try
                            {
                                switch (commandArr[1])
                                {
                                    case "add":
                                        {
                                            init.Add(commandArr[2], int.Parse(commandArr[3]));
                                            break;
                                        }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Command...");
                            }
                            break;
                        }
                    case "clear": case "cl":{
                            Console.Clear();
                            break;
                        }
                    case "end":{
                            return;
                        }
                    default:{
                            Console.WriteLine("Invalid Command...");
                            Thread.Sleep(500);
                            break;
                        }
                }
            }
        }
    }
}