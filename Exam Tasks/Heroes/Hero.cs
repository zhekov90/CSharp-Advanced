using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        private string name;
        private int level;
        private Item item;

        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public Item Item
        {
            get { return item; }
            set { item = value; }
        }

        public override string ToString()
        {
            return $"Hero: {this.Name} – {this.Level}lvl" + Environment.NewLine + $"Item:" + Environment.NewLine + $"  * Strength: {Item.Strength}" + Environment.NewLine + $"  * Ability: {Item.Ability}" + Environment.NewLine + $"  * Intelligence: {Item.Intelligence}";
        }
    }
}
