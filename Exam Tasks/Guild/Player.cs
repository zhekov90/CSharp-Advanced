﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {

        public Player()
        {
            this.Rank = "Trial";
            this.Description = "n/a";
        }

        public Player(string name, string classs)
            :this()
        {
            this.Name = name;
            this.Class = classs;
        }
        public string Name { get; set; }

        public string Class { get; set; }

        public string Rank { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {this.Name}: {this.Class}".ToString());
            sb.AppendLine($"Rank: {Rank}".ToString());
            sb.AppendLine($"Description: {Description}".ToString());
            return sb.ToString().TrimEnd();       
        }
    }
}

