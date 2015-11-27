using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeartRobotGenerator
{
    class EhDefects
    {
        //fields
        private int Gain;
        private string Name;
        private string Description;

        //constructor
        public EhDefects(string name, string description, int gain)
        {
            this.Name = name;
            this.Description = description;
            this.Gain = gain;
        }

        //Methods
        public string ReturnName()
        {
            return this.Name;
        }

        public string ReturnDescription()
        {
            return this.Description;
        }

        public int ReturnGain()
        {
            return this.Gain;
        }
    }
}
