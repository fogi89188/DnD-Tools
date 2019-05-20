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
            miniStats.Add(rand.Next(6)+1);
            Thread.Sleep(10);
            miniStats.Add(rand.Next(6)+1);
            Thread.Sleep(10);
            miniStats.Add(rand.Next(6)+1);
            Thread.Sleep(10);
            miniStats.Add(rand.Next(6)+1);
            Thread.Sleep(10);

            for (int j = 0; j < miniStats.Count; j++)
            {
                Console.WriteLine(miniStats[j]);
            }

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
            int sum = 0;
            int st1 = GenerateAStat();
            int st2 = GenerateAStat();
            int st3 = GenerateAStat();
            int st4 = GenerateAStat();
            int st5 = GenerateAStat();
            int st6 = GenerateAStat();
            sum = st1 + st2 + st3 + st4 + st5 + st6;
            Console.WriteLine(sum);
            if (sum <= 70)
            {
                GenerateAllStatsOnce();
            }
            stat1.Add(st1);
            stat2.Add(st2);
            stat3.Add(st3);
            stat4.Add(st4);
            stat5.Add(st5);
            stat6.Add(st6);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Stats:");
            for (int i = 0; i < repeat; i++)
            {
                sb.Append($"\n| {stat1[i]} | {stat2[i]} | {stat3[i]} | {stat4[i]} | {stat5[i]} | {stat6[i]} |");
            }

            return sb.ToString();
        }
    }
}
