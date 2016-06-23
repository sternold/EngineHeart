using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public class Feature : IPart
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public int Rank { get; set; }

        public Feature(string name, int cost)
        {
            Name = name;
            Cost = -1 * cost;
        }
    }
}
