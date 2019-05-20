using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DnDTools
{
    class CharacterStatGeneratorClass
    {
        private int rand;
        private int repeat = 0;
        private List<int> stat1;
        private List<int> stat2;
        private List<int> stat3;
        private List<int> stat4;
        private List<int> stat5;
        private List<int> stat6;

        public CharacterStatGeneratorClass()
        {
        }

        public List<int> Stat1 { get => stat1; set => stat1 = value; }
        public List<int> Stat2 { get => stat2; set => stat2 = value; }
        public List<int> Stat3 { get => stat3; set => stat3 = value; }
        public List<int> Stat4 { get => stat4; set => stat4 = value; }
        public List<int> Stat5 { get => stat5; set => stat5 = value; }
        public List<int> Stat6 { get => stat6; set => stat6 = value; }

        public int GenerateAStat(int stat)
        {
            Random rand = new Random();
            List<int> miniStats = new List<int>();
            miniStats.Add(rand.Next(7));
            Thread.Sleep(5);
            miniStats.Add(rand.Next(7));
            Thread.Sleep(5);
            miniStats.Add(rand.Next(7));
            Thread.Sleep(5);
            miniStats.Add(rand.Next(7));

            int i = 0;
            int temp = i;
            int min = miniStats[i];
            for (i = 0; i < miniStats.Count; i++)
            {
                if (miniStats[i] < min)
                {
                    min = miniStats[i];
                    temp = i;
                }
            }
            miniStats.RemoveAt(temp);
            int sum = 0;
            for (i = 0; i < miniStats.Count; i++)
            {
                sum += miniStats[i];
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Stats:");
            for (int i = 0; i < repeat; i++)
            {
                sb.Append($"\n{Stat1[i]} | {Stat2[i]} | {Stat3[i]} | {Stat4[i]} | {Stat5[i]} | {Stat6[i]}");
            }

            return sb.ToString();
        }
    }
}
