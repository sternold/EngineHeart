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

        ///<summary>
        ///Contains common tags descriptive of the Part.
        ///</summary>
        public List<string> Tags { get; set; }

        public int Rank { get; set; }

        public Part(int id, string name, int cost)
        {
            ID = id;
            Name = name;
            Value = cost;
        }

        /// <summary>
        /// Compares the Name value.
        /// </summary>
        public int CompareTo(object obj)
        {
            return Name.CompareTo(obj);
        }

        public override string ToString()
        {
            return $"{Name} {Rank}";
        }
    }
}
