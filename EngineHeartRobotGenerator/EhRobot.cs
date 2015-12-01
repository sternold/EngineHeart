using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeartRobotGenerator
{
    class EhRobot
    {
        //fields
        private int Points;

        private List<EhAttributes> Attributes;
        private List<EhFeatures> Features;
        private List<EhDefects> Defects;
        private int[] OtherFactorsq;

        //OTHER FACTORS?

        //constructor
        public EhRobot(int points)
        {
            this.Points = points;

            this.Attributes = new List<EhAttributes> { new EhAttributes("RealityCom"), new EhAttributes("HumanCom"), new EhAttributes("DigiCon"), new EhAttributes("MechaniCon"),
            new EhAttributes("Dexterity"), new EhAttributes("Mobility"), new EhAttributes("Perception"), new EhAttributes("Reflexes"), new EhAttributes("Strength"),
            new EhAttributes("Durability"), new EhAttributes("Buffer"), new EhAttributes("Size"), new EhAttributes("Power")};   
                 
            this.Features = new List<EhFeatures> { };
            this.Defects = new List<EhDefects> { };

            this.Points = RollRobot(this.Points);

            this.OtherFactors = new int[] { };
        }

        //methods
        private int RollRobot(int x)
        {
            int Save = x;
            while (x != 0)
            {
                x = Save;
                x += RollAttributes();
            }
            return x;
        }
        
        private int RollAttributes()
        {
            int x = 0;
            foreach (EhAttributes att in this.Attributes)
            {
                att.Roll();
                x += att.ReturnCost();
            }
            return x;
        }

        public int AttributeValue(int index)
        {
            return this.Attributes[index].ReturnValue();
        }

    }
}
