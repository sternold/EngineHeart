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

        //Tags describe abilities of the Robot
        public List<string> Tags { get; set; }

        public int Rank { get; set; }

        public Part(int id, string name, int cost)
        {
            ID = id;
            Name = name;
            Value = cost;
        }

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
