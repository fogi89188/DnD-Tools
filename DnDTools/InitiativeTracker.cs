using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTools
{
    class InitiativeTracker
    {
        private SortedDictionary<int, string> initiative = new SortedDictionary<int, string>();

        public InitiativeTracker(SortedDictionary<int, string> initiative)
        {
            this.initiative = initiative;
        }

        public void Add(string name, int init)
        {
            initiative.Add(init, name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Initiative:");
            int i = 1;
            foreach (var item in initiative)
            {
                sb.Append($"\n{i}: {item.Key} - {item.Value}");
                i++;
            }
            return sb.ToString(); 
        }
    }
}
