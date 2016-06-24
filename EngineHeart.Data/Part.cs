using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public class Part : IComparable
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int Value { get; set; }

        public int Rank { get; set; }

        public int CompareTo(object obj)
        {
            return ID.CompareTo(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
