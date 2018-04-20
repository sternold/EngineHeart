using System;
using System.Collections.Generic;
using EngineHeart.Core.Interfaces;

namespace EngineHeart.Core.Models
{
    public class Robot : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Player { get; set; }
        public string OriginalPurpose { get; set; }

        //Intelligence
        public int RealityCom { get; set; }
        public int HumanCom { get; set; }
        public int DigiCon { get; set; }
        public int MechaniCon { get; set; }

        //Chassis
        public int Dexterity { get; set; }
        public int Mobility { get; set; }
        public int Perception { get; set; }
        public int Reflexes { get; set; }
        public int Strength { get; set; }

        //Crux
        public int Durability { get; set; }
        public int Buffer { get; set; }
        public int Size { get; set; }
        public int Power { get; set; }

        //Physical Interaction
        public int InteractionPool
        {
            get
            {
                return Dexterity + Reflexes;
            }
        }
        public int TnToBeStruck
        {
            get
            {
                return Mobility + Reflexes;
            }
        }
        public int DamageFromStrike
        {
            get
            {
                return Convert.ToInt32(Math.Round(new Decimal(Strength / 2)));
            }
        }

        //Movement
        public int Initiative
        {
            get
            {
                return Reflexes;
            }
        }
        public int Speed
        {
            get
            {
                return Mobility + Reflexes;
            }
        }

        //Thresholds
        public int OsThreshold
        {
            get
            {
                return DigiCon + Buffer;
            }
        }
        public int DamageThreshold
        {
            get
            {
                return Durability + Size;
            }
        }

        public HashSet<RobotComponent> Components { get; set; }

        public Robot()
        {
            Components = new HashSet<RobotComponent>();
        }
    }
}
