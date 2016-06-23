using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public class Robot
    {
        public string Name { get; set; }
        public string Purpose { get; set; }

        public List<Attribute> Attributes { get; set; }
        public List<IPart> Parts { get; set; }

        public Robot()
        {

        }
    }
}
