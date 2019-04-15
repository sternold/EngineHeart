using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EngineHeart.Core.Entity
{
    public class Robot : Base.Entity
    {
        #region Robot Info
        public string Name { get; set; }
        public string Player { get; set; }
        public string OriginalPurpose { get; set; }
        #endregion

        #region Attributes
        private readonly int[] _attributes = new int[13];
        public int[] Attributes => _attributes;
        public int Attribute(int i) => _attributes[i];
        #endregion

        #region Intelligence
        public int RealityCom { get => _attributes[0]; set => _attributes[0] = value; }
        public int HumanCom { get => _attributes[1]; set => _attributes[1] = value; }
        public int DigiCon { get => _attributes[2]; set => _attributes[2] = value; }
        public int MechaniCon { get => _attributes[3]; set => _attributes[3] = value; }
        #endregion

        #region Chassis
        public int Dexterity { get => _attributes[4]; set => _attributes[4] = value; }
        public int Mobility { get => _attributes[5]; set => _attributes[5] = value; }
        public int Perception { get => _attributes[6]; set => _attributes[6] = value; }
        public int Reflexes { get => _attributes[7]; set => _attributes[7] = value; }
        public int Strength { get => _attributes[8]; set => _attributes[8] = value; }
        #endregion

        #region Crux
        public int Durability { get => _attributes[9]; set => _attributes[9] = value; }
        public int Buffer { get => _attributes[10]; set => _attributes[10] = value; }
        public int Size { get => _attributes[11]; set => _attributes[11] = value; }
        public int Power { get => _attributes[12]; set => _attributes[12] = value; }
        #endregion

        #region Physical Interaction
        public int InteractionPool => Dexterity + Reflexes;
        public int TnToBeStruck => Mobility + Reflexes;
        public int DamageFromStrike => Convert.ToInt32(Math.Round(new decimal(Strength / 2)));
        #endregion

        #region Movement
        public int Initiative => Reflexes;
        public int Speed => Mobility + Reflexes;
        #endregion

        #region Thresholds
        public int OsThreshold => DigiCon + Buffer;
        public int DamageThreshold => Durability + Size;
        #endregion

        #region Components
        public ICollection<Component> Components { get; set; }
        #endregion

        public Robot()
        {
            Components = new List<Component>();
        }
    }
}
