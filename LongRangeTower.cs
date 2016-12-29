using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseGame
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 4;
 
        protected override string TowerType { get; } = "Long Range Tower";

        public LongRangeTower(MapLocation location) : base(location)
        { }
    }
}
