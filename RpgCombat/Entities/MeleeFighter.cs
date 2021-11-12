using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCombat.Entities
{
    class MeleeFighter : Character
    {
        public int MaxRange { get; set; }

        public MeleeFighter(string name): base(name)
        {
            MaxRange = 2;
        }

        public override string ToString()
        {
            return "DATASHEET:" +
                $"{Name}, Level:{Level}, Health:{Health}, Max Range: {MaxRange}m";
        }
    }
}
