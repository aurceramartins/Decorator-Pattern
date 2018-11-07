using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class GunSilencer : GunDecorator
    {

        public override float NoiseLevel { get { return Dg.NoiseLevel - 20; } }

        public GunSilencer(Gun g) : base(g)
        {
        }


        public override string Render()
        {
            return base.Dg.Render() + "Gun Silencer ";
        }
    }
}
