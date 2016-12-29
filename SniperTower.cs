using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseGame
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;
        protected override double Accuracy { get; } = .85;
        protected override string TowerType { get; } = "Sniper Tower";

        public SniperTower(MapLocation location) : base(location)
        {}
    }
}
