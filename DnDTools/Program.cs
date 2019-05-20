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
            CharacterStatGeneratorClass cs = new CharacterStatGeneratorClass();
            string command = "";
            while (command != "end")
            {
                string[] commandArr = Console.ReadLine().Split().ToArray();
                switch (commandArr[0])
                {
                    case "stat":
                        {
                            try
                            {
                                cs.GenerateAllNTimes(int.Parse(commandArr[1]));
                                Console.WriteLine(cs.ToString());
                            }
                            catch(Exception)
                            {
                                cs.GenerateAllNTimes(1);
                                Console.WriteLine(cs.ToString());
                            }
                            break;
                        }
                    case "initiative":
                        {
                            break;
                        }
                    case "end":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Command...");
                            Thread.Sleep(500);
                            break;
                        }
                }
            }
        }
    }
}