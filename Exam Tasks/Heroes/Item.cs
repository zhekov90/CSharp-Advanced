using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
   public class Item
    {
        private int strength;
        private int ability;
        private int intelligence;

        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Ability
        {
            get { return ability; }
            set { ability = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public override string ToString()
        {
            return $"Item:" + Environment.NewLine + $"  * Strength: {this.Strength}" + Environment.NewLine + $"  * Ability: {this.Ability}" + Environment.NewLine + $"  * Intelligence: {this.Intelligence}";

        }
    }
}
