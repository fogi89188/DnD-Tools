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
        private int repeat = 1;
        private static List<int> stat1 = new List<int>();
        private static List<int> stat2 = new List<int>();
        private static List<int> stat3 = new List<int>();
        private static List<int> stat4 = new List<int>();
        private static List<int> stat5 = new List<int>();
        private static List<int> stat6 = new List<int>();

        public CharacterStatGeneratorClass()
        {
        }


        public int GenerateAStat()
        {
            Random rand = new Random();
            List<int> miniStats = new List<int>();
            Thread.Sleep(10);
            miniStats.Add(rand.Next(6) + 1);
            Thread.Sleep(10);
            miniStats.Add(rand.Next(6) + 1);
            Thread.Sleep(10);
            miniStats.Add(rand.Next(6) + 1);
            Thread.Sleep(10);
            miniStats.Add(rand.Next(6) + 1);
            Thread.Sleep(10);

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
        public void GenerateAllStatsOnce()
        {
            int st1 = GenerateAStat();
            int st2 = GenerateAStat();
            int st3 = GenerateAStat();
            int st4 = GenerateAStat();
            int st5 = GenerateAStat();
            int st6 = GenerateAStat();

            stat1.Add(st1);
            stat2.Add(st2);
            stat3.Add(st3);
            stat4.Add(st4);
            stat5.Add(st5);
            stat6.Add(st6);
        }
        public void GenerateAllNTimes(int rep){
            repeat += rep - 1;
            Console.WriteLine(repeat);
            for(int i = 0; i < repeat; i++)
            {
                GenerateAllStatsOnce();
            }
        }

        public override string ToString()
        {
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Stats:");
            for (int i = 0; i < repeat; i++)
            {
                sum = stat1[i] + stat2[i] + stat3[i] + stat4[i] + stat5[i] + stat6[i];
                sb.Append($"\n| {stat1[i]} | {stat2[i]} | {stat3[i]} | {stat4[i]} | {stat5[i]} | {stat6[i]} | - Sum: {sum}");
                sum = 0;
            }
            repeat = 1;

            return sb.ToString();
        }
    }
}
