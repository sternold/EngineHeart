using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public class Defect : Part
    {
        public Defect(int id, string name, int cost)
        {
            ID = id;
            Name = name;
            Value = cost;
        }
    }
}
