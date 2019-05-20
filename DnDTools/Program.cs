using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTools
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterStatGeneratorClass cs = new CharacterStatGeneratorClass();
            cs.GenerateAllStatsOnce();
            Console.WriteLine(cs.ToString());
        }
    }
}
