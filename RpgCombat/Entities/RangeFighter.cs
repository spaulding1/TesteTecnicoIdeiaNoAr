using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCombat.Entities
{
    class RangeFighter : Character
    {
        public int MaxRange { get; set; }

        public RangeFighter(string name) : base(name)
        {
            MaxRange = 20;
        }

        public override string ToString()
        {
            return "DATASHEET:" +
                $"{Name}, Level:{Level}, Health:{Health}, Max Range: {MaxRange}m";
        }
    }
}
