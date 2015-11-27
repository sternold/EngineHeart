using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineHeartRobotGenerator
{
    class EhAttributes
    {
        //fields
        private string Name;
        private int Value;
        private int Cost;
        private bool IsOtherFactor;
        private static Random Dice = new Random();

        //Constructor
        public EhAttributes(string name, bool OF = false)
        {
            this.Name = name;
            this.Value = 0;
            this.Cost = 0;
            this.IsOtherFactor = OF;
        }

        //Methods
        public string ReturnName()
        {
            return this.Name;
        }

        public int ReturnValue()
        {
            return this.Value;
        }

        public int ReturnCost()
        {
            return this.Cost;
        }

        public void Roll()
        {
            if (!this.IsOtherFactor)
            {
                this.Value = Dice.Next(1, 6);
                CalcCost();
            }           
        }

        private void CalcCost()
        {
            int x = 0;
            for (int i = 0; i <= this.Value; i++)
            {
                x += i;
            }
            this.Cost = x*-1;
        }

        //Other Factors
        public bool OtherFactor()
        {
            return this.IsOtherFactor;
        }

        public void SetValue(int x)
        {
            this.Value = x;
        }
    }
}
