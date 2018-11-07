using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ShotGun : Gun
    {
        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }

        public ShotGun(int amo, float noise)
        {
            AmmoCapacity = amo;
            NoiseLevel = noise;
        }

        public override string Render()
        {
            return "ShotGun ";
        }
    }
}
