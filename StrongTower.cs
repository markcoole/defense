using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseGame
{
    class StrongTower : Tower
    {
        protected override int Power { get; } = 4;
        protected override double Accuracy { get; } = .55;
        protected override string TowerType { get; } = "Strong Tower";

        public StrongTower(MapLocation location) : base(location)
        { }
    }
}
