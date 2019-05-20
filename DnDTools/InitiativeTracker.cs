using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTools
{
    class InitiativeTracker
    {
        Dictionary<string, int> initiative = new Dictionary<string, int>();

        public InitiativeTracker(Dictionary<string, int> initiative)
        {
            this.initiative = initiative;
        }

        public void Add(string name, int init)
        {
            initiative.Add(name, init);
        }
    }
}
