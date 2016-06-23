using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public class Defect : IPart
    {
        public string Name { get; set; }
        public int Gain { get; set; }

        public int Rank { get; set; }

        public Defect(string name, int gain)
        {
            Name = name;
            Gain = gain;
        }
    }
}
