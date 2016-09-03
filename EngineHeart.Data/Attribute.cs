using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeart.Data
{
    public class Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Value { get; private set; }
        
        public Attribute(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }

        ///<summary>
        ///Creates a random value for property 'Value' and returns Cost of the value.
        ///</summary>
        public int GenerateValue(Random r)
        {
            Value = r.Next(1, 6);
            return ((Value*(Value+1))/2);
        }


    }
}
