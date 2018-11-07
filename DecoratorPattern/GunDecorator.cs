using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class GunDecorator : Gun
    {
        public override int AmmoCapacity { get { return Dg.AmmoCapacity; } }
        public override float NoiseLevel { get { return Dg.NoiseLevel; } }

        public Gun Dg { get; }

        protected GunDecorator(Gun g)
        {
            Dg = g;
        }
    }
}
