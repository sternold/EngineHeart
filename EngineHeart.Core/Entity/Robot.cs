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
        private int[] attributes = new int[13];
        public int[] Attributes() => attributes;
        public int Attribute(int i) => attributes[i];
        #endregion

        #region Intelligence
        public int RealityCom { get => attributes[0]; set => attributes[0] = value; }
        public int HumanCom { get => attributes[1]; set => attributes[1] = value; }
        public int DigiCon { get => attributes[2]; set => attributes[2] = value; }
        public int MechaniCon { get => attributes[3]; set => attributes[3] = value; }
        #endregion

        #region Chassis
        public int Dexterity { get => attributes[4]; set => attributes[4] = value; }
        public int Mobility { get => attributes[5]; set => attributes[5] = value; }
        public int Perception { get => attributes[6]; set => attributes[6] = value; }
        public int Reflexes { get => attributes[7]; set => attributes[7] = value; }
        public int Strength { get => attributes[8]; set => attributes[8] = value; }
        #endregion

        #region Crux
        public int Durability { get => attributes[9]; set => attributes[9] = value; }
        public int Buffer { get => attributes[10]; set => attributes[10] = value; }
        public int Size { get => attributes[11]; set => attributes[11] = value; }
        public int Power { get => attributes[12]; set => attributes[12] = value; }
        #endregion

        #region Physical Interaction
        public int InteractionPool => Dexterity + Reflexes;
        public int TnToBeStruck => Mobility + Reflexes;
        public int DamageFromStrike => Convert.ToInt32(Math.Round(new Decimal(Strength / 2)));
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
        public IList<Component> Components { get; set; }
        #endregion

        public Robot()
        {
            Components = new List<Component>();
        }
    }
}
