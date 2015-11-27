using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeartRobotGenerator
{
    class EhFeatures
    {
        //fields
        private int Cost;
        private string Name;
        private string Description;

        //constructor
        public EhFeatures(string name, string description, int cost)
        {
            this.Name = name;
            this.Description = description;
            this.Cost = cost*-1;
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

        public int ReturnCost()
        {
            return this.Cost;
        }
    }
}
